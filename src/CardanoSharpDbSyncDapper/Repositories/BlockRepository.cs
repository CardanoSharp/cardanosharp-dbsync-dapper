using Application.Common;
using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using Microsoft.Extensions.Configuration;

namespace CardanoSharpDbSyncDapper.Repositories
{
    public interface IBlockRepository : IGenericRepository<Block>
    {
    }

    public class BlockRepository : GenericRepository<Block>, IBlockRepository
    {
        public BlockRepository(ICardanoDbConnection configuration)
            : base(configuration, TableNames.Block) { }
    }
}
