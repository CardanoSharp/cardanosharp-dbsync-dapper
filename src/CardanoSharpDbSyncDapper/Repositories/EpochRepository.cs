using Application.Common;
using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IEpochRepository : IGenericRepository<Epoch>
    {
    }
    public class EpochRepository : GenericRepository<Epoch>, IEpochRepository
    {
        public EpochRepository(IDbConnection configuration)
            : base(configuration, TableNames.Epoch) { }
    }
}
