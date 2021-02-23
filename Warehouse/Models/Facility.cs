using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Warehouse.Models
{
    [Table("FACILITY")]
    public class Facility
    {
        [Column("FACILITY_ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("TITLE", TypeName = "VARCHAR(50)")]
        public string Title { get; set; }

        [Required]
        [Column("FACILITY_CODE", TypeName = "VARCHAR(7)")]
        public string Code { get; set; }
    }
}