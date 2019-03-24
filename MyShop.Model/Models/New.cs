namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("New")]
    public partial class New
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Title { get; set; }

        [StringLength(250)]
        [Required]
        public string Link { get; set; }

        public int? CategoryId { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Description { get; set; }
    }
}
