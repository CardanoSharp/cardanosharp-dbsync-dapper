using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IMaTxMintRepository : IGenericRepository<MaTxMint>
    {
    }
    public class MaTxMintRepository : GenericRepository<MaTxMint>, IMaTxMintRepository
    {
        public MaTxMintRepository(IConfiguration configuration)
            : base(configuration, TableNames.MaTxMint) { }
    }
}
