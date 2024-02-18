using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoMania.Features.Environment
{
    public enum Environment
    {
        DEV,
        QA,
        PROD
    }

    public interface IEnvironmentContext
    {
        Environment Environment { get; }
        string DbPath { get; }
    }
}
