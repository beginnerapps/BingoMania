using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using System.IO;

namespace BingoMania.Features.Database
{
    public interface ISqlLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
    public interface IDbContext
    {
        string Path { get; }
        string DbName { get; }
    }
    public abstract class SqlLiteDb : ISqlLiteDb
    {
        public SqlLiteDb(IDbContext dbContext)
        {
            Context = dbContext;
        }

        protected readonly IDbContext Context;

        public SQLiteAsyncConnection GetConnection()
        {
            var connection = new SQLiteAsyncConnection(Path.Combine(Context.Path, Context.DbName), SQLiteOpenFlags.ReadWrite | SQLiteOpenFlags.Create, true);
            return connection;
        }
    }

    public interface IBingoManiaDb
    {
        Task<bool> InitializeDb();
    }

    public class BingoManiaDb : SqlLiteDb, IBingoManiaDb
    {
        public BingoManiaDb(IDbContext context) : base(context)
        {

        }

        public async Task<bool> InitializeDb()
        {
            await Task.Delay(2000);

            var conn = GetConnection();
            await conn.CloseAsync();

            return true;
        }

    }
}
