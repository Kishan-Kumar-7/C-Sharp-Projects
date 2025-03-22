using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                //this is lambda syntex
                var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                //This is Linq method
                //var signups = (from c in db.SignUps where c.Removed == null select c).ToList();
                List<SignupVM> signupsVMS = new List<SignupVM>();
                foreach (var signup in signups)
                {
                    SignupVM signupVM = new SignupVM();
                    signupVM.Id = signup.Id;
                    signupVM.FirstName = signup.FirstName;
                    signupVM.LastName = signup.LastName;
                    signupVM.EmailAddress = signup.EmailAddress;
                    signupsVMS.Add(signupVM);
                }
                return View(signupsVMS);
            }
        }
        public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            { 
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
                return RedirectToAction("Index");
        }
    }
}