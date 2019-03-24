namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Banner")]
    public partial class Banner
    {
        public int Id { get; set; }

        [StringLength(500)]
        [Required]
        public string Image { get; set; }
        [Required]

        public bool? Status { get; set; }
    }
}
