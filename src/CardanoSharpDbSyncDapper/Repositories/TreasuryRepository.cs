using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITreasuryRepository : IGenericRepository<Treasury>
    {
    }
    public class TreasuryRepository : GenericRepository<Treasury>, ITreasuryRepository
    {
        public TreasuryRepository(IConfiguration configuration)
            : base(configuration, TableNames.Treasury) { }
    }
}
