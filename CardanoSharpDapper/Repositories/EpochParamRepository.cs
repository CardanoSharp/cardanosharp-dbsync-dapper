using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IEpochParamRepository : IGenericRepository<EpochParam>
    {
    }
    public class EpochParamRepository : GenericRepository<EpochParam>, IEpochParamRepository
    {
        public EpochParamRepository(IDbConnection configuration)
            : base(configuration, TableNames.EpochParam) { }
    }
}
