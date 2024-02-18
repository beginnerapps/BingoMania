using BingoMania.Framework.Views;
using Dawn;
using Microsoft.Maui.Controls;
using ReactiveUI;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace BingoMania.Features.Startup
{
    public sealed class StartupPageViewModel : ViewModelBase
    {
        public IReactiveCommand StartCommand { get; }
        public StartupPageViewModel(IStartupSequencer startupSequencer, INavigation navigation)
            : base(navigation)
        {
            _startupSequencer = Guard.Argument(startupSequencer, nameof(startupSequencer))
                .NotNull()
                .Value;

            var canStart = _startupSequencer.IsInProgress
                .StartWith(false)
                .Select(x => !x);

            StartCommand = ReactiveCommand.CreateFromTask(ExecuteStartCommand, canStart)
                .DisposeWith(TrashBin);
        }

        private async Task ExecuteStartCommand()
        {
            var result = await _startupSequencer.Run();

            if (result)
            {
                //Continue to load Home Page!
            }
            else
            {
                //Show the Error or whatever
            }
        }

        private readonly IStartupSequencer _startupSequencer;
    }
}
