using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AspNetMVCEssential.Models
{
    public class CheckoutAccount
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "账户必须是6-10个字符")]
        [Display(Name = "账户")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "姓")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "名")]
        public string LastName { get; set; }
        [Display(Name = "姓名")]
        public string Name { get { return FirstName + " " + LastName; } }

        [Required]
        [Display(Name = "余额")]
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}