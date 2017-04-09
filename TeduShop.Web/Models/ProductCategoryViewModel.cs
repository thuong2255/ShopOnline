using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Web.Models
{
    public class ProductCategoryViewModel
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }
        public int ParentID { get; set; }
        public int? DisplayOrder { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public bool? HomeFlag { get; set; }
        public virtual IEnumerable<ProductViewModel> Products { get; set; }
        public System.DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime? UpdatedDate { get; set; }
        public string UpdateBy { get; set; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }

        [Required]
        public bool Status { get; set; }
    }
}