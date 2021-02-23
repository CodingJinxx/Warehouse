using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Warehouse.Models
{
    [Table("FUNDING")]
    public class Funding
    {
        [Column("PROJECT_ID")]
        public int ProjectId { get; set; }
        public AProject Project { get; set; }

        [Column("DEBTIOR_ID")]
        public int DebitorId { get; set; }
        public Debitor Debitor { get; set; }

        [Column("FUNDING_AMOUNT", TypeName = "DECIMAL(10)")]
        public float Amount { get; set; }
    }
}