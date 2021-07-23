using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolUpdateRepository : IGenericRepository<PoolUpdate>
    {
    }
    public class PoolUpdateRepository : GenericRepository<PoolUpdate>, IPoolUpdateRepository
    {
        public PoolUpdateRepository(IDbConnection configuration)
            : base(configuration, TableNames.PoolUpdate) { }
    }
}
