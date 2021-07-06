using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class MaTxMintMap : EntityMap<MaTxMint>
    {
        public MaTxMintMap()
        {
            Map(p => p.TxId).ToColumn("tx_id");
        }
    }
}
