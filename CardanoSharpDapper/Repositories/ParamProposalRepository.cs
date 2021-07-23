using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

#nullable disable

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IParamProposalRepository : IGenericRepository<ParamProposal>
    {
    }
    public class ParamProposalRepository : GenericRepository<ParamProposal>, IParamProposalRepository
    {
        public ParamProposalRepository(IDbConnection configuration)
            : base(configuration, TableNames.ParamProposal) { }
    }
}
