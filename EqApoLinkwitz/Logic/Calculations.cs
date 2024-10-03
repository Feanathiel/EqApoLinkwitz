using EqApoLinkwitz.DataStructures;
using EqApoLinkwitz.Extensions;

namespace EqApoLinkwitz.Logic;

static class Calculations
{
    public static FilterParameters CreateFilterParameters(LoadSaveData loadSaveData)
    {
        // Analog coefficients
        var d0i = Math.Pow(2 * Math.PI * loadSaveData.Frequency0, 2);
        var d1i = (2 * Math.PI * loadSaveData.Frequency0) / loadSaveData.Qtc0;
        var d2i = loadSaveData.LowPassHighPassRatio;

        var c0i = Math.Pow(2 * Math.PI * loadSaveData.FrequencyP, 2);
        var c1i = (2 * Math.PI * loadSaveData.FrequencyP) / loadSaveData.QtcP;
        var c2i = loadSaveData.LowPassHighPassRatio;

        // normalized frequency
        var cornerFrequency = (loadSaveData.Frequency0 + loadSaveData.FrequencyP) / 2;
        var gn = (2 * Math.PI * cornerFrequency) / (Math.Tan(Math.PI * cornerFrequency / loadSaveData.SampleFrequency));

        // filter coefficient
        var cci =       c0i + gn * c1i + (gn * gn) * c2i;

        // Digital coefficients

        // a coefficients (zeros)
        var a0 =       (c0i + gn * c1i + (gn * gn) * c2i) / cci; // should always be 1, but kept for consistency
        var a1 = -(2 * (c0i            - (gn * gn) * c2i) / cci);
        var a2 = -(    (c0i - gn * c1i + (gn * gn) * c2i) / cci);

        // b coefficients (poles)
        var b0 =       (d0i + gn * d1i + (gn * gn) * d2i) / cci;
        var b1 =   2 * (d0i            - (gn * gn) * d2i) / cci;
        var b2 =       (d0i - gn * d1i + (gn * gn) * d2i) / cci;

        return new FilterParameters(
            loadSaveData.SampleFrequency,
            new BiquadFilter(a0, a1, a2, b0, b1, b2));
    }
    
    public static Correction CreateCorrection(FilterParameters filterParameters, LoadSaveData loadSaveData)
    {
        var mapped = InfiniteEnumerable.Of(Math.Pow(2, 1d / 8))
            .Scan(10d, (prev, current) => prev * current)
            .TakeWhile(freq => (int)freq <= 20480)
            .Select(freq =>
            {
                var w = 2 * Math.PI * freq / filterParameters.SampleFrequency;
                var phi = 4 * Math.Pow(Math.Sin(w / 2), 2);
                var eq = filterParameters.BiquadFilter.Apply(phi);

                return new EqualizerBand
                (
                    freq,
                    eq * loadSaveData.Scale
                );
            })
            .ToList();

        var preampGain = mapped.Max(x => x.Gain) * -1;
        
        return new Correction(mapped, preampGain);
    }
}