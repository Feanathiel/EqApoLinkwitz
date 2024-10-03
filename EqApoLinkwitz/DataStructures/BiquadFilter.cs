namespace EqApoLinkwitz.DataStructures;

public record BiquadFilter(double a0, double a1, double a2, double b0, double b1, double b2)
{
    public bool IsStable()
    {
        var d = -a1 * -a1 - 4 * a0 * -a2;
        return Math.Abs(d) < 1;
    }

    public double Apply(double phi)
    {
        var eq = 10 * Math.Log10(Math.Pow(b0 + b1 + b2, 2) + (b0 * b2 * phi - (b1 * (b0 + b2) + 4 * b0 * b2)) * phi)
                 - 10 * Math.Log10(Math.Pow(a0 + -a1 + -a2, 2) + (a0 * -a2 * phi - (-a1 * (a0 + -a2) + 4 * a0 * -a2)) * phi);

        return eq;
    }
}