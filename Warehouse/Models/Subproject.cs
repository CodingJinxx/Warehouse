using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Models
{
    [Table("SUBPROJECTS")]
    public class Subproject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SUBPROJECT_ID")]
        public int Id { get; set; }

        [Required]
        [Column("DESCRIPTION", TypeName = "VARCHAR(255)")]
        public string Description { get; set; }

        [Required]
        [Column("APPLIED_RESEARCH", TypeName = "TINYINT(1)")]
        public bool AppliedResearch { get; set; }
        
        [Column("THEORETICAL_RESEARCH", TypeName = "TINYINT(1)")]
        [Required]
        public bool TheoreticalResearch { get; set; }
        
        [Column("FOCUS_RESEARCH", TypeName = "TINYINT(1)")]
        [Required]
        public bool FocusResearch { get; set; }
    }
}