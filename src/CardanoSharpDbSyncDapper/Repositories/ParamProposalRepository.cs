using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IParamProposalRepository : IGenericRepository<ParamProposal>
    {
    }
    public class ParamProposalRepository : GenericRepository<ParamProposal>, IParamProposalRepository
    {
        public ParamProposalRepository(IConfiguration configuration)
            : base(configuration, TableNames.ParamProposal) { }
    }
}
