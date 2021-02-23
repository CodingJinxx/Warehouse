using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Models
{
    [Table("PROJECTS")]
    public abstract class AProject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("PROJECT_ID")]
        public int Id { get; set; }
        [Required]
        [Column("TITLE", TypeName = "VARCHAR(100)")]
        public string Title { get; set; }
        // [Column("DESCRIPTION", TypeName = "VARCHAR(255)")]
        // public string Description { get; set; }
        [Required]
        [Column("LEGAL_FOUNDATION", TypeName = "VARCHAR(4)")]
        public string LegalFoundation { get; set; } 
    }
}