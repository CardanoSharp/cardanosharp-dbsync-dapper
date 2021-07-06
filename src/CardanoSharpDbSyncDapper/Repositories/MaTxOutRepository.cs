using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IMaTxOutRepository : IRepository<MaTxOut>
    {
    }
    public class MaTxOutRepository : Repository<MaTxOut>, IMaTxOutRepository
    {
        public MaTxOutRepository(IConfiguration configuration)
            : base(configuration, TableNames.MaTxOut) { }
    }
}
