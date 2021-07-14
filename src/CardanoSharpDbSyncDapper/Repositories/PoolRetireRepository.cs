using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolRetireRepository : IGenericRepository<PoolRetire>
    {
    }
    public class PoolRetireRepository : GenericRepository<PoolRetire>, IPoolRetireRepository
    {
        public PoolRetireRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolRetire) { }
    }
}
