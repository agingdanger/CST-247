using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Authorize(user userModel)
        {
            using (seesharpEntities db = new seesharpEntities())
            {
                var userDetails = db.users.Where(x => x.username == userModel.username && x.password == userModel.password).FirstOrDefault();
                if (userDetails == null)
                {
                    return View("Login", userModel);
                }
                else
                {
                    Session["ID"] = userDetails.ID;
                    return RedirectToAction("Index", "Home");
                }
            }
            // return View();
        }
    }
}