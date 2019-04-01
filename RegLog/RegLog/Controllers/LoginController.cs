using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegLog.Models;

namespace RegLog.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Log()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(user userModel)
        {
            using (seesharpEntities db = new seesharpEntities())
            {
                var userDetails = db.users.Where(x => x.email == userModel.email && x.firstname == userModel.firstname && x.lastname == userModel.lastname).FirstOrDefault();
                if(userDetails == null)
                {
                    return View("Login", userModel);
                }
                else
                {
                    Session["ID"] = userDetails.ID;
                    return RedirectToAction("Index" , "Home");
                }
            }
           // return View();
        }
    }
}