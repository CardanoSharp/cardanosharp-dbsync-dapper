using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IMaTxMintRepository : IGenericRepository<MaTxMint>
    {
    }
    public class MaTxMintRepository : GenericRepository<MaTxMint>, IMaTxMintRepository
    {
        public MaTxMintRepository(IDbConnection configuration)
            : base(configuration, TableNames.MaTxMint) { }
    }
}
