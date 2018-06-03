using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6_Capstone_TaskListRevisted.Controllers
{
    public class HomeController : Controller
    {
       

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Tasks
           (string description = "descrbe in words", int duedate = 12/31/2018, 
            int status = 2, string email = "none@noone.com", int taskID = 0000, 
            int userID = 9999)
        {
            return View();
        }

        public ActionResult TaskMgrLogin()
        {
            return View();
        }

        public ActionResult Employees()
        {
            return View();
        }

        //    (string firstName = "Whatever1", string lastName = "Whatever2",
        //    string email = "none@noone.com", int userID = 000)
        //{
        //    ViewBag.FirstName = firstName;
        //    ViewBag.LastName = lastName;
        //    ViewBag.Email = email;
        //    ViewBag.UserID = userID;
        //    return View();
        //}

       

        public ActionResult Welcome(string firstName = "Whatever", 
            string lastName = "Knowhere", string emailAddress = "none@none.com", 
            string passWord1 = "password", string passWord2 = "password")
        {
            //ActionResults
            ViewBag.First = firstName;
            ViewBag.Last = lastName;
            ViewBag.Email = emailAddress;
            ViewBag.Password1 = passWord1;
            ViewBag.Password2 = passWord2;
            return View();
        }
    }
}