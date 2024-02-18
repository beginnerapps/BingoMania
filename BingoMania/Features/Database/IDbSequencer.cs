using BingoMania.Features.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoMania.Features.Database
{
    public interface IDbSequencer : IStartupSequenceItem
    {
    }

    public class DbSequencer : IDbSequencer
    {
        public DbSequencer()
        {
            ContinueOnFailure = false;
        }
        public bool ContinueOnFailure { get; }

        public string Status { get; }

        public async Task<bool> Run()
        {
            return true;
        }

        public async Task<bool> ShouldRun()
        {
            return true;
        }
    }
}
