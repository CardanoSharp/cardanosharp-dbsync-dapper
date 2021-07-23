using CardanoSharpDbSyncDapper.Models;
using Dapper.FluentMap.Mapping;

namespace CardanoSharpDbSyncDapper.Mappings
{
    public class EpochMap : EntityMap<Epoch>
    {
        public EpochMap()
        {
            Map(p => p.OutSum).ToColumn("out_sum");
            Map(p => p.TxCount).ToColumn("tx_count");
            Map(p => p.BlkCount).ToColumn("blk_count");
            Map(p => p.StartTime).ToColumn("start_time");
            Map(p => p.EndTime).ToColumn("end_time");
        }
    }
}
