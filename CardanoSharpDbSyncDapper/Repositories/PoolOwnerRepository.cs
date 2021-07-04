using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolOwnerRepository : IRepository<PoolOwner>
    {
    }
    public class PoolOwnerRepository : Repository<PoolOwner>, IPoolOwnerRepository
    {
        public PoolOwnerRepository(IConfiguration configuration)
            : base(configuration, TableNames.PoolOwner) { }
    }
}
