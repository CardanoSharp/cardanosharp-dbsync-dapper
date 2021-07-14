using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IRewardRepository : IGenericRepository<Reward>
    {
    }
    public class RewardRepository : GenericRepository<Reward>, IRewardRepository
    {
        public RewardRepository(IConfiguration configuration)
            : base(configuration, TableNames.Reward) { }
    }
}
