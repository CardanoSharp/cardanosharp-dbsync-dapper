using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolUpdateRepository : IGenericRepository<PoolUpdate>
    {
    }
    public class PoolUpdateRepository : GenericRepository<PoolUpdate>, IPoolUpdateRepository
    {
        public PoolUpdateRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolUpdate) { }
    }
}
