using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IRewardRepository : IGenericRepository<Reward>
    {
    }
    public class RewardRepository : GenericRepository<Reward>, IRewardRepository
    {
        public RewardRepository(IDbConnection configuration)
            : base(configuration, TableNames.Reward) { }
    }
}
