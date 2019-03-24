namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bill")]
    public partial class Bill
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CreateDate { get; set; }
        [Required]
        public int? CustomerId { get; set; }

        [StringLength(250)]
        [Required]
        public string ShipAddress { get; set; }
        [Required]
        public int? Status { get; set; }
    }
}
