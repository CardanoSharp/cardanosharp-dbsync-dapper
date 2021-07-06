using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IMetumRepository : IRepository<Metum>
    {
    }
    public class MetumRepository : Repository<Metum>, IMetumRepository
    {
        public MetumRepository(IConfiguration configuration)
            : base(configuration, TableNames.Metum) { }
    }
}
