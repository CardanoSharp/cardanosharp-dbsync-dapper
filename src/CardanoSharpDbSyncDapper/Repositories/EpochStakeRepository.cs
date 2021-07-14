using Application.Common;
using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IEpochStakeRepository : IGenericRepository<EpochStake>
    {
    }
    public class EpochStakeRepository : GenericRepository<EpochStake>, IEpochStakeRepository
    {
        public EpochStakeRepository(ICardanoDbConnection configuration)
            : base(configuration, TableNames.EpochStake) { }
    }
}
