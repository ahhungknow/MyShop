namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BillDetail")]
    public partial class BillDetail
    {
        public int Id { get; set; }
        [Required]
        public int? BillId { get; set; }
        [Required]
        public int? ProductId { get; set; }
        [Required]
        public int? Amount { get; set; }
    }
}
