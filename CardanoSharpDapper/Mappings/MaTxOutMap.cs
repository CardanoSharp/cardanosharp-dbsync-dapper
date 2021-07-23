using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class MaTxOutMap : EntityMap<MaTxOut>
    {
        public MaTxOutMap()
        {
            Map(p => p.TxOutId).ToColumn("tx_out_id");
        }
    }
}
