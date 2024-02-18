using BingoMania.Framework.Views;
using Microsoft.Maui.Controls;

namespace BingoMania.Features.Startup
{
    public partial class StartupPage : ContentPageBase<StartupPageViewModel>
    {
        public StartupPage(StartupPageViewModel startupPageViewModel) : base(startupPageViewModel)
        {
            InitializeComponent();
        }
    }
}
