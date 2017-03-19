using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Orders")]
    public class Order : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string PaymentMethod { set; get; }

        [Required]
        [MaxLength(256)]
        public string PaymentStatus { set; get; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}