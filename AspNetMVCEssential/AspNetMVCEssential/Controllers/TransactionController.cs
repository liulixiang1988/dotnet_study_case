using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMVCEssential.Models;
using Microsoft.AspNet.Identity;

namespace AspNetMVCEssential.Controllers
{
    [Authorize]
    public class TransactionController : Controller
    {
        //
        // GET: /Transaction/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Transaction/Deposite
        public ActionResult Deposit()
        {
            return View();
        }

        //
        // POST: /Transaction/Deposite
        [HttpPost]
        public ActionResult Deposit(Transaction transaction)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //应该为假，因为数据不完整
                }
                var userId = User.Identity.GetUserId();
                var db = new ApplicationDbContext();
                var account = db.CheckoutAccounts.First(a => a.ApplicationUserId == userId);
                account.Balance += transaction.Amount;
                transaction.CheckoutAccountId = account.Id;
                db.Transactions.Add(transaction);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
