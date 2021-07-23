using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IEpochStakeRepository : IGenericRepository<EpochStake>
    {
    }
    public class EpochStakeRepository : GenericRepository<EpochStake>, IEpochStakeRepository
    {
        public EpochStakeRepository(IDbConnection configuration)
            : base(configuration, TableNames.EpochStake) { }
    }
}
