using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolRelayRepository : IRepository<PoolRelay>
    {
    }
    public class PoolRelayRepository : Repository<PoolRelay>, IPoolRelayRepository
    {
        public PoolRelayRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolRelay) { }
    }
}
