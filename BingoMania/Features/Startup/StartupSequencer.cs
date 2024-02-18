using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace BingoMania.Features.Startup
{
    public sealed class StartupSequencer : IStartupSequencer
    {
        public StartupSequencer(IEnumerable<IStartupSequenceItem> startupSequenceItems)
        {
            _startupSequenceItems = startupSequenceItems.ToList();
        }

        async Task<bool> IStartupSequencer.Run()
        {
            _isInProgress.OnNext(true);
            var total = _startupSequenceItems.Count;
            var current = 0;

            await Task.Delay(10000);

            foreach (var startupSequenceItem in _startupSequenceItems)
            {
                _progress.OnNext((current++, total));
                if (await startupSequenceItem.ShouldRun())
                {
                    _statusMessage.OnNext(startupSequenceItem.Status);
                    try
                    {
                        await startupSequenceItem.Run();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error Occurred while executing StartupItem:" + ex.Message);
                        if (startupSequenceItem.ContinueOnFailure)
                        {
                            continue;
                        }

                        return false;
                    }
                }
            }
            _isInProgress.OnNext(false);
            return true;
        }


        public IObservable<string> StatusMessage => _statusMessage;
        public IObservable<(int, int)> Progress => _progress;

        public IObservable<bool> IsInProgress => _isInProgress;

        private readonly Subject<string> _statusMessage = new Subject<string>();
        private readonly Subject<(int, int)> _progress = new Subject<(int, int)>();
        private readonly Subject<bool> _isInProgress = new Subject<bool>();

        private readonly IReadOnlyList<IStartupSequenceItem> _startupSequenceItems;

    }
}
