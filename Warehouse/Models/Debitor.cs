using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Models
{
    [Table("DEBITOR")]
    public class Debitor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("DEBITOR_ID")]
        public int Id { get; set; }
        
        [Required]
        [Column("NAME", TypeName = "VARCHAR(100)")]
        public string Name { get; set; }
    }
}