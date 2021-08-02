using CardanoSharpDbSyncDapper.Common;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoSharpDbSyncDapper.Models
{
    [Table(TableNames.OrphanedReward)]
    public partial class OrphanedReward
    {
        public long Id { get; set; }
        public long AddrId { get; set; }
        public decimal Amount { get; set; }
        public long EpochNo { get; set; }
        public long PoolId { get; set; }
        public long BlockId { get; set; }

        public virtual StakeAddress Addr { get; set; }
        public virtual Block Block { get; set; }
        public virtual PoolHash Pool { get; set; }
    }
}
