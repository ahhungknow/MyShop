namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        [Required]
        public string Link { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Description { get; set; }

        [StringLength(500)]
        [Required]
        public string Image { get; set; }
        [Required]
        public int? Quanity { get; set; }
        [Required]
        public int? ViewCount { get; set; }

        public int? CategoryId { get; set; }
        [Required]
        public bool? ShowOnHome { get; set; }
        [Required]
        public bool? Special { get; set; }
        [Required]
        public int? Sale { get; set; }
    }
}
