using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolRelayRepository : IGenericRepository<PoolRelay>
    {
    }
    public class PoolRelayRepository : GenericRepository<PoolRelay>, IPoolRelayRepository
    {
        public PoolRelayRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolRelay) { }
    }
}
