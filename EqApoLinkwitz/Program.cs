using EqApoLinkwitz.UI.Presenters;
using EqApoLinkwitz.UI.Views;

namespace EqApoLinkwitz;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        
        var mainForm = new MainForm();
        using var mainPresenter = new MainPresenter(mainForm);
        
        Application.Run(mainForm);
    }
}