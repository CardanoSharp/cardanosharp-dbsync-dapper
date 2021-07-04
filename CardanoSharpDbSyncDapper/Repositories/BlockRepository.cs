using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IBlockRepository : IRepository<Block>
    {
    }

    public class BlockRepository : Repository<Block>, IBlockRepository
    {
        public BlockRepository(IConfiguration configuration)
            : base(configuration, TableNames.Block) { }
    }
}
