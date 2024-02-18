using BingoMania.Features.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoMania.Features.Database
{
    public class BingoManiaDbContext : IDbContext
    {
        public BingoManiaDbContext(IEnvironmentContext environmentContext)
        {
            _environmentContext = environmentContext;
        }

        public string Path => _environmentContext.DbPath;
        public string DbName => $"{_environmentContext.Environment}.db";

        private readonly IEnvironmentContext _environmentContext;
    }
}
