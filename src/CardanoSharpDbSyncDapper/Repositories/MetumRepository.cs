using Application.Common;
using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IMetumRepository : IGenericRepository<Metum>
    {
    }
    public class MetumRepository : GenericRepository<Metum>, IMetumRepository
    {
        public MetumRepository(ICardanoDbConnection configuration)
            : base(configuration, TableNames.Metum) { }
    }
}
