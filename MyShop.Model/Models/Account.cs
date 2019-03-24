namespace MyShop.Model.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [StringLength(50)]
        [Required]
        public string Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Password { get; set; }

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
    }
}
