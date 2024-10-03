namespace EqApoLinkwitz.DataStructures;

record Correction(
    IEnumerable<EqualizerBand> EqualizerBands, 
    double PreampGain
);