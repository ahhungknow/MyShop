namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slide")]
    public partial class Slide
    {
        public int Id { get; set; }

        [StringLength(500)]
        [Required]
        public string Image { get; set; }

        [StringLength(250)]
        [Required]
        public string Link { get; set; }
        [Required]
        public int? Order { get; set; }
        [Required]
        public bool? Status { get; set; }
    }
}
