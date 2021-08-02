using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IStakeAddressRepository : IGenericRepository<StakeAddress>
    {
    }
    public class StakeAddressRepository : GenericRepository<StakeAddress>, IStakeAddressRepository
    {
        public StakeAddressRepository(IDbConnection configuration)
            : base(configuration, TableNames.StakeAddress) { }
    }
}
