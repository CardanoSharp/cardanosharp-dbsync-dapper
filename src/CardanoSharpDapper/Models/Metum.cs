using CardanoSharpDbSyncDapper.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace CardanoSharpDbSyncDapper.Models
{
    [Table(TableNames.Metum)]
    public partial class Metum
    {
        public long Id { get; set; }
        public DateTime StartTime { get; set; }
        public string NetworkName { get; set; }
    }
}
