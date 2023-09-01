using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assesment_16.Models
{
    [Table("Tasks")]
    public class Tasks
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
    }
}
