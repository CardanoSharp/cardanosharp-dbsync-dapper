using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IOrphanedRewardRepository : IGenericRepository<OrphanedReward>
    {
    }
    public class OrphanedRewardRepository : GenericRepository<OrphanedReward>, IOrphanedRewardRepository
    {
        public OrphanedRewardRepository(IDbConnection configuration)
            : base(configuration, TableNames.OrphanedReward) { }
    }
}
