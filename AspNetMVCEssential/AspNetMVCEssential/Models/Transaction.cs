using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMVCEssential.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "金额")]
        public decimal Amount { get; set; }

        public virtual CheckoutAccount Account { get; set; }

        [Required]
        public int CheckoutAccountId { get; set; }
    }
}