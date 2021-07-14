using Application.Common;
using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IEpochParamRepository : IGenericRepository<EpochParam>
    {
    }
    public class EpochParamRepository : GenericRepository<EpochParam>, IEpochParamRepository
    {
        public EpochParamRepository(ICardanoDbConnection configuration)
            : base(configuration, TableNames.EpochParam) { }
    }
}
