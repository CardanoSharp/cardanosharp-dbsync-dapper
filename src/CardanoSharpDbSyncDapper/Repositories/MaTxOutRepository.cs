using Application.Common;
using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IMaTxOutRepository : IGenericRepository<MaTxOut>
    {
    }
    public class MaTxOutRepository : GenericRepository<MaTxOut>, IMaTxOutRepository
    {
        public MaTxOutRepository(ICardanoDbConnection configuration)
            : base(configuration, TableNames.MaTxOut) { }
    }
}
