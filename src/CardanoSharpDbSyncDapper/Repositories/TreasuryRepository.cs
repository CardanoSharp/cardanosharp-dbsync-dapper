using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface ITreasuryRepository : IRepository<Treasury>
    {
    }
    public class TreasuryRepository : Repository<Treasury>, ITreasuryRepository
    {
        public TreasuryRepository(IConfiguration configuration)
            : base(configuration, TableNames.Treasury) { }
    }
}
