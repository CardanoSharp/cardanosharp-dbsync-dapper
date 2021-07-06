using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IParamProposalRepository : IRepository<ParamProposal>
    {
    }
    public class ParamProposalRepository : Repository<ParamProposal>, IParamProposalRepository
    {
        public ParamProposalRepository(IConfiguration configuration)
            : base(configuration, TableNames.ParamProposal) { }
    }
}
