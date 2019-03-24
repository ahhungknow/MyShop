namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        [Required]
        public string Link { get; set; }
        [Required]
        public int? ParentId { get; set; }
        [Required]
        public int? Order { get; set; }
    }
}
