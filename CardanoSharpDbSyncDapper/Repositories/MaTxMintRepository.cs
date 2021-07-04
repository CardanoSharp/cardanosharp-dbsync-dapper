using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IMaTxMintRepository : IRepository<MaTxMint>
    {
    }
    public class MaTxMintRepository : Repository<MaTxMint>, IMaTxMintRepository
    {
        public MaTxMintRepository(IConfiguration configuration)
            : base(configuration, TableNames.MaTxMint) { }
    }
}
