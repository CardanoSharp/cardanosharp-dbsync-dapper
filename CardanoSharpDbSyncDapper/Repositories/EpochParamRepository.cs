using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IEpochParamRepository : IRepository<EpochParam>
    {
    }
    public class EpochParamRepository : Repository<EpochParam>, IEpochParamRepository
    {
        public EpochParamRepository(IConfiguration configuration)
            : base(configuration, TableNames.EpochParam) { }
    }
}
