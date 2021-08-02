using CardanoSharp.DbSync.EntityFramework.Models;
using Dapper.FluentMap.Mapping;

#nullable disable

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class TxMetadatumMap : EntityMap<TxMetadatum>
    {
        public TxMetadatumMap()
        {
            Map(p => p.TxId).ToColumn("tx_id");
        }
    }
}
