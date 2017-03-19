using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        public int CategoryID { get; set; }
        public int? DisplayOrder { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public bool? HomeFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategories { get; set; }

        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}