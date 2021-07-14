using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolMetaDatumRepository : IGenericRepository<PoolMetaDatum>
    {
    }
    public class PoolMetaDatumRepository : GenericRepository<PoolMetaDatum>, IPoolMetaDatumRepository
    {
        public PoolMetaDatumRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolMetaDatum) { }
    }
}
