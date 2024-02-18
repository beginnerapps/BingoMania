using BingoMania.Features.Environment;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoMania.Platforms.Android
{
    public sealed class EnvironmentContext : IEnvironmentContext
    {
        public Features.Environment.Environment Environment => Features.Environment.Environment.DEV; //Read Environment From Manifest!

        public string DbPath => Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), Constants.DataStore);
    }
}
