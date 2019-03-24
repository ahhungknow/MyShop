namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("About")]
    public partial class About
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Details { get; set; }
        [Required]
        public bool? Status { get; set; }
    }
}
