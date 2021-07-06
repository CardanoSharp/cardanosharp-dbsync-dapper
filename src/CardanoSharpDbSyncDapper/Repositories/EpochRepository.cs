using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IEpochRepository : IRepository<Epoch>
    {
    }
    public class EpochRepository : Repository<Epoch>, IEpochRepository
    {
        public EpochRepository(IConfiguration configuration)
            : base(configuration, TableNames.Epoch) { }
    }
}
