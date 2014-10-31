using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMVCEssential.Models
{
    public class CheckoutAccount
    {
        public int Id { get; set; }

        public string AccountNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Balance { get; set; }
    }
}