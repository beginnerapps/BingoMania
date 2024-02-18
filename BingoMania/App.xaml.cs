using BingoMania.Features.Startup;
using Microsoft.Maui.Controls;

namespace BingoMania;

public partial class App : Application
{
    public App(StartupPage startupPage)
    {
        InitializeComponent();
        MainPage = startupPage;
    }
}
