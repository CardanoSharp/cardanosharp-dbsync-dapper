﻿using System;
using System.Collections.Generic;

#nullable disable

namespace CardanoSharp.DbSync.EntityFramework.Models
{
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
