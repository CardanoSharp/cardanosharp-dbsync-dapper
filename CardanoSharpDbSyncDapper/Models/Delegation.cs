using CardanoSharpDbSyncDapper.Common;
using System.ComponentModel.DataAnnotations.Schema;
#nullable disable

namespace CardanoSharpDbSyncDapper.Models
{
    [Table(TableNames.Delegation)]
    public partial class Delegation
    {
        public long Id { get; set; }
        public long AddrId { get; set; }
        public int CertIndex { get; set; }
        public long PoolHashId { get; set; }
        public long ActiveEpochNo { get; set; }
        public long TxId { get; set; }
        public int SlotNo { get; set; }

        public virtual StakeAddress Addr { get; set; }
        public virtual PoolHash PoolHash { get; set; }
        public virtual Tx Tx { get; set; }
    }
}
