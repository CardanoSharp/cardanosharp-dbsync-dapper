using CardanoSharpDbSyncDapper.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoSharpDbSyncDapper.Models
{
    [Table(TableNames.PoolUpdate)]
    public partial class PoolUpdate
    {
        public PoolUpdate()
        {
            PoolRelays = new HashSet<PoolRelay>();
        }

        public long Id { get; set; }
        public long HashId { get; set; }
        public int CertIndex { get; set; }
        public byte[] VrfKeyHash { get; set; }
        public decimal Pledge { get; set; }
        public long ActiveEpochNo { get; set; }
        public long? MetaId { get; set; }
        public double Margin { get; set; }
        public decimal FixedCost { get; set; }
        public long RegisteredTxId { get; set; }
        public byte[] RewardAddr { get; set; }

        public virtual PoolHash Hash { get; set; }
        public virtual PoolMetaDatum Meta { get; set; }
        public virtual Tx RegisteredTx { get; set; }
        public virtual ICollection<PoolRelay> PoolRelays { get; set; }
    }
}
