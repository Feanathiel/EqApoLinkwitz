namespace EqApoLinkwitz.UI.Events;

public class SaveEventArgs(string? filePath) : EventArgs
{
    public string? FilePath { get; } = filePath;
}