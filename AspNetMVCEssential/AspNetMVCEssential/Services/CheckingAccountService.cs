using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspNetMVCEssential.Models;

namespace AspNetMVCEssential.Services
{
    public class CheckingAccountService
    {
        private ApplicationDbContext db;

        public CheckingAccountService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreateCheckingAccount(string firstName, string lastName,
            string userId, decimal initalBalance)
        {
            var db = new ApplicationDbContext();
            var accountNumber = (123456 + db.CheckoutAccounts.Count()).ToString().PadLeft(10, '0');
            var checkoutAccount = new CheckoutAccount
            {
                AccountNumber = accountNumber,
                FirstName = firstName,
                LastName = lastName,
                Balance = initalBalance,
                ApplicationUserId = userId
            };
            db.CheckoutAccounts.Add(checkoutAccount);
            db.SaveChanges();
        }
    }
}