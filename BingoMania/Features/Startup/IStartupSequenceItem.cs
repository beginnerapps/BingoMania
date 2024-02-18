using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoMania.Features.Startup
{
    public interface IStartupSequenceItem
    {
        bool ContinueOnFailure { get; }
        Task<bool> ShouldRun();
        Task<bool> Run();
        string Status { get; }
    }
}
