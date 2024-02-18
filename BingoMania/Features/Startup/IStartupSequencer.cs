using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoMania.Features.Startup
{
    public interface IStartupSequencer
    {
        IObservable<bool> IsInProgress { get; }
        IObservable<string> StatusMessage { get; }
        IObservable<(int, int)> Progress { get; }
        Task<bool> Run();
    }
}
