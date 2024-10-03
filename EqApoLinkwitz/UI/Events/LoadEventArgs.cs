namespace EqApoLinkwitz.UI.Events;

public class LoadEventArgs(string filePath) : EventArgs
{
    public string FilePath { get; } = filePath;
}