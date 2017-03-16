using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string ID { set; get; }

        [Required]
        public String Content { set; get; }
    }
}