using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolHashRepository : IGenericRepository<PoolHash>
    {
    }
    public class PoolHashRepository : GenericRepository<PoolHash>, IPoolHashRepository
    {
        public PoolHashRepository(IDbConnection configuration)
            : base(configuration, TableNames.PoolHash) { }
    }
}
