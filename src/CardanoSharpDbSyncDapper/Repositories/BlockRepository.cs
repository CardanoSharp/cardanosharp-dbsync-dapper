using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.Data;

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IBlockRepository : IGenericRepository<Block>
    {
    }

    public class BlockRepository : GenericRepository<Block>, IBlockRepository
    {
        public BlockRepository(IDbConnection configuration)
            : base(configuration, TableNames.Block) { }
    }
}
