using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IRewardRepository : IRepository<Reward>
    {
    }
    public class RewardRepository : Repository<Reward>, IRewardRepository
    {
        public RewardRepository(IConfiguration configuration)
            : base(configuration, TableNames.Reward) { }
    }
}
