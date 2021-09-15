using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IPoolOwnerRepository : IGenericRepository<PoolOwner>
    {
    }
    public class PoolOwnerRepository : GenericRepository<PoolOwner>, IPoolOwnerRepository
    {
        public PoolOwnerRepository(IDbConnection configuration)
            : base(configuration, TableNames.PoolOwner) { }
    }
}
