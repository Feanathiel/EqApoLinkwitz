using System.Globalization;
using System.Text;
using EqApoLinkwitz.DataStructures;

namespace EqApoLinkwitz.Logic;

static class FileIo
{
    private record LoadSaveAction(
        Action<LoadSaveData.Builder, string> Parse, 
        Func<LoadSaveData, string> Serialize
    );

    private static readonly Dictionary<string, LoadSaveAction> LoadSaveActions = new()
    {
        {
            "f(0)",
            new LoadSaveAction(
                (data, value) => data.Frequency0 = ParseDouble(value),
                data => data.Frequency0.ToString("F3", CultureInfo.InvariantCulture)
            )
        },
        {
            "Q(0)",
            new LoadSaveAction(
                (data, value) => data.Qtc0 = ParseDouble(value),
                data => data.Qtc0.ToString("F5", CultureInfo.InvariantCulture)
            )
        },
        {
            "f(p)",
            new LoadSaveAction(
                (data, value) => data.FrequencyP = ParseDouble(value),
                data => data.FrequencyP.ToString("F3", CultureInfo.InvariantCulture)
            )
        },
        {
            "Q(p)",
            new LoadSaveAction(
                (data, value) => data.QtcP = ParseDouble(value),
                data => data.QtcP.ToString("F5", CultureInfo.InvariantCulture)
            )
        },
        {
            "LP/HP",
            new LoadSaveAction(
                (data, value) => data.LowPassHighPassRatio = ParseDouble(value),
                data => data.LowPassHighPassRatio.ToString("F3", CultureInfo.InvariantCulture)
            )
        },
        {
            "Fs",
            new LoadSaveAction(
                (data, value) => data.SampleFrequency = ParseDouble(value),
                data => data.SampleFrequency.ToString("F0", CultureInfo.InvariantCulture)
            )
        },
        {
            "scale",
            new LoadSaveAction(
                (data, value) => data.Scale = ParseDouble(value),
                data => data.Scale.ToString("F3", CultureInfo.InvariantCulture)
            )
        },
    };
    
    public static async Task<LoadSaveData?> LoadAsync(string filePath)
    {
        var lines = await File.ReadAllTextAsync(filePath);

        return Deserialize(lines);
    }

    public static async Task SaveAsync(string filePath, LoadSaveData data, Correction correction)
    {
        var contents = Serialize(data, correction);
        await File.WriteAllTextAsync(filePath, contents);
    }
    
    public static LoadSaveData GetDefault()
    {
        var a = Math.Sqrt(1d / 2);

        return new LoadSaveData.Builder
        {
            Qtc0 =  a,
            FrequencyP = 15,
            QtcP = a,
            LowPassHighPassRatio = 0.75,
            SampleFrequency = 48000,
            Scale = 1,
            Frequency0 = 130
        }.Build();
    }

    private static string Serialize(LoadSaveData data, Correction correction)
    {
        var loadParametersParts = LoadSaveActions
            .Select(loadSaveAction => $"{loadSaveAction.Key}={loadSaveAction.Value.Serialize(data)}")
            .ToList();

        var sb = new StringBuilder();
        sb.AppendLine($"# {string.Join(", ", loadParametersParts)}");
        sb.AppendLine($"Preamp: {correction.PreampGain:F9} dB");
        sb.AppendLine($"GraphicEQ: {string.Join("; ", correction.EqualizerBands.Select(x => $"{x.Frequency:F9} {x.Gain:F9}"))}");
        return sb.ToString();
    }

    private static LoadSaveData? Deserialize(string fileContents)
    {
        var lines = fileContents.Split('\r', '\n');
        var line = lines.First();

        if (!line.StartsWith("#"))
        {
            return null;
        }

        var parts = line.TrimStart('#')
            .Split(',')
            .Select(x =>
            {
                var p = x.Split("=");

                return new
                {
                    Key = p[0].Trim(),
                    Value = p[1].Trim()
                };
            });

        var data = new LoadSaveData.Builder();

        foreach (var part in parts)
        {
            if (!LoadSaveActions.TryGetValue(part.Key, out var loadSaveAction))
            {
                throw new InvalidOperationException("What does this even mean?");
            }

            loadSaveAction.Parse(data, part.Value);
        }

        return data.Build();
    }

    private static double ParseDouble(string value) => double.Parse(value, CultureInfo.InvariantCulture);
}