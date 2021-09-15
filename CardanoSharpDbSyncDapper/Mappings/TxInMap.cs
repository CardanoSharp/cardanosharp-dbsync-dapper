using CardanoSharp.DbSync.EntityFramework.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class TxInMap : EntityMap<TxIn>
    {
        public TxInMap()
        {
            Map(p => p.TxInId).ToColumn("tx_in_id");
            Map(p => p.TxOutId).ToColumn("tx_out_id");
            Map(p => p.TxOutIndex).ToColumn("tx_out_index");
        }
    }
}
