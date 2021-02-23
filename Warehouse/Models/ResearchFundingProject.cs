using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Models
{
    [Table("RESEARCH_FUNDING_PROJECTS")]
    public class ResearchFundingProject : AProject
    {
        [Required]
        [Column("IS_FWF_SPONSORED", TypeName = "TINYINT(1)")]
        public bool  IsFWFSponsored{ get; set; }
        [Required]
        [Column("IS_FFG_SPONSORED", TypeName = "TINYINT(1)")]
        public bool IsFFGSponsored { get; set; }
        [Required]
        [Column("IS_EU_SPONSORED", TypeName = "TINYINT(1)")]
        public bool IsEUSponsored { get; set; }
    }
}