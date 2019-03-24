namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(250)]
        [Required]
        public string Address { get; set; }

        [StringLength(10)]
        [Required]
        public string Phone { get; set; }

        [StringLength(250)]
        [Required]
        public string Email { get; set; }
        [Required]
        public bool? Status { get; set; }

        [StringLength(50)]
        [Required]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
