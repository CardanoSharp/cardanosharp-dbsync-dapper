﻿using CardanoSharpDbSyncDapper.Common;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoSharpDbSyncDapper.Models
{
    [Table(TableNames.Withdrawal)]
    public partial class Withdrawal
    {
        public long Id { get; set; }
        public long AddrId { get; set; }
        public decimal Amount { get; set; }
        public long TxId { get; set; }

        public virtual StakeAddress Addr { get; set; }
        public virtual Tx Tx { get; set; }
    }
}
