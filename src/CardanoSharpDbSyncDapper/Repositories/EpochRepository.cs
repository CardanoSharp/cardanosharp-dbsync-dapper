using Application.Common;
using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IEpochRepository : IGenericRepository<Epoch>
    {
    }
    public class EpochRepository : GenericRepository<Epoch>, IEpochRepository
    {
        public EpochRepository(ICardanoDbConnection configuration)
            : base(configuration, TableNames.Epoch) { }
    }
}
