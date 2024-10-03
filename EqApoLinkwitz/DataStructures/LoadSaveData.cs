namespace EqApoLinkwitz.DataStructures;

record LoadSaveData(
    double Qtc0,
    double FrequencyP,
    double QtcP,
    double LowPassHighPassRatio,
    double SampleFrequency,
    double Scale,
    double Frequency0
)
{
    public class Builder
    {
        public double Qtc0 { get; set; }
        public double FrequencyP { get; set; }
        public double QtcP { get; set; }
        public double LowPassHighPassRatio { get; set; }
        public double SampleFrequency { get; set; }
        public double Scale { get; set; }
        public double Frequency0 { get; set; }

        public LoadSaveData Build() => new(
            Qtc0,
            FrequencyP,
            QtcP,
            LowPassHighPassRatio,
            SampleFrequency,
            Scale,
            Frequency0
        );
    }
}