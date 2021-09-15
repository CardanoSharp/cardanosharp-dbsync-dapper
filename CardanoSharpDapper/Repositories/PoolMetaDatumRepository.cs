using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolMetaDatumRepository : IGenericRepository<PoolMetaDatum>
    {
    }
    public class PoolMetaDatumRepository : GenericRepository<PoolMetaDatum>, IPoolMetaDatumRepository
    {
        public PoolMetaDatumRepository(IDbConnection configuration)
            : base(configuration, TableNames.PoolMetaDatum) { }
    }
}
