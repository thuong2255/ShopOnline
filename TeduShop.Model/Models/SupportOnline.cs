using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string Mobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string Email { set; get; }

        [MaxLength(256)]
        public string Skype { set; get; }

        [MaxLength(256)]
        public string Department { set; get; }
    }
}