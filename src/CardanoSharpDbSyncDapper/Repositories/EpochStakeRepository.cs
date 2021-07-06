using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IEpochStakeRepository : IRepository<EpochStake>
    {
    }
    public class EpochStakeRepository : Repository<EpochStake>, IEpochStakeRepository
    {
        public EpochStakeRepository(IConfiguration configuration)
            : base(configuration, TableNames.EpochStake) { }
    }
}
