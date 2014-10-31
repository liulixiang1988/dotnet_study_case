using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMVCEssential.Models
{
    public class CheckoutAccount
    {
        public int Id { get; set; }

        [Required]
        //[StringLength(10, MinimumLength = 6)]
        [RegularExpression(@"\d{6,10}", ErrorMessage = "账户必须是6-10个字符")]
        [Display(Name = "账户")]
        public string AccountNumber { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Display(Name = "姓名")]
        public string Name { get { return FirstName + " " + LastName; } }

        [Required]
        [DataType(DataType.Currency)]
        public int Balance { get; set; }
    }
}