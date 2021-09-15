using CardanoSharpDbSyncDapper.Common;
using CardanoSharpDbSyncDapper.Models;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoSharp.DbSync.EntityFramework.Models
{
    [Table(TableNames.TxMetadatum)]
    public partial class TxMetadatum
    {
        public long Id { get; set; }
        public decimal Key { get; set; }
        public string Json { get; set; }
        public long TxId { get; set; }
        public byte[] Bytes { get; set; }

        public virtual Tx Tx { get; set; }
    }
}
