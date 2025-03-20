using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterAppMVC.ViewModels;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string FirstName, string LastName, string EmailAddress)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress))
            {
                return View("~/Views/Shared/error.cshtml");
            }
            else 
            {
                string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES (@FirstName, @LastName, @EmailAddress)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    using (SqlCommand command = new SqlCommand(queryString, connection))
                    {
                        command.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
                        command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
                        command.Parameters.Add("@EmailAddress", SqlDbType.VarChar).Value = EmailAddress;
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    
                }
                return View("Success");
            }
        }
        public ActionResult Admin() 
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress FROM SignUps";
            List<Models.NewsletterSignup> signups = new List<Models.NewsletterSignup>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Models.NewsletterSignup signup = new Models.NewsletterSignup();
                        signup.Id = (int)reader["Id"];
                        signup.FirstName = reader["FirstName"].ToString();
                        signup.LastName = reader["LastName"].ToString();
                        signup.EmailAddress = reader["EmailAddress"].ToString();
                        signups.Add(signup);
                    }
                    connection.Close();
                }
            }
            List<SignupVM> signupsVMS = new List<SignupVM>();
            foreach (var signup in signups)
            {
                SignupVM signupVM = new SignupVM();
                signupVM.FirstName = signup.FirstName;
                signupVM.LastName = signup.LastName;
                signupVM.EmailAddress = signup.EmailAddress;
                signupsVMS.Add(signupVM);
            }
            return View(signupsVMS); 
        }

    }
}