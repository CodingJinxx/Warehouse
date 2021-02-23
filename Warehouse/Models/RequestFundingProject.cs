using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Models
{
    [Table("REQUEST_FUNDING_PROJECTS")]
    public class RequestFundingProject : AProject
    {
        [Required]
        [Column("IS_SMALL_PROJECT", TypeName = "TINYINT(1)")]
        public bool IsSmallProject { get; set; }
    }
}