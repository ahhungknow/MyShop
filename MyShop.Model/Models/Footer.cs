namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Footer")]
    public partial class Footer
    {
        public int Id { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Content { get; set; }
        [Required]
        public bool? Status { get; set; }
    }
}
