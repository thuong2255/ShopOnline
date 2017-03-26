using System.Collections.Generic;

namespace TeduShop.Web.Models
{
    public class PostViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Alias { get; set; }

        public int CategoryID { get; set; }
        public int? DisplayOrder { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }

        public bool? HomeFlag { get; set; }
        public int? ViewCount { get; set; }

        public virtual PostCategoryViewModel PostCategories { get; set; }

        public virtual IEnumerable<PostTagViewModel> PostTags { get; set; }

        public System.DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public System.DateTime? UpdatedDate { get; set; }

        public string UpdateBy { get; set; }

        public string MetaKeyword { set; get; }

        public string MetaDescription { set; get; }

        public bool Status { get; set; }
    }
}