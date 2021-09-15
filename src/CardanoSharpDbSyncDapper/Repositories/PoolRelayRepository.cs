using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolRelayRepository : IGenericRepository<PoolRelay>
    {
    }
    public class PoolRelayRepository : GenericRepository<PoolRelay>, IPoolRelayRepository
    {
        public PoolRelayRepository(IDbConnection configuration)
            : base(configuration, TableNames.PoolRelay) { }
    }
}
