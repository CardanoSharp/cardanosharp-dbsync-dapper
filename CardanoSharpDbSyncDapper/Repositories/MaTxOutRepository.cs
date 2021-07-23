using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IMaTxOutRepository : IGenericRepository<MaTxOut>
    {
    }
    public class MaTxOutRepository : GenericRepository<MaTxOut>, IMaTxOutRepository
    {
        public MaTxOutRepository(IDbConnection configuration)
            : base(configuration, TableNames.MaTxOut) { }
    }
}
