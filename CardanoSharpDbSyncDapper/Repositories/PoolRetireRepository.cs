using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolRetireRepository : IGenericRepository<PoolRetire>
    {
    }
    public class PoolRetireRepository : GenericRepository<PoolRetire>, IPoolRetireRepository
    {
        public PoolRetireRepository(IDbConnection configuration)
            : base(configuration, TableNames.PoolRetire) { }
    }
}
