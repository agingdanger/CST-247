using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Store.Models;

namespace Store.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public string Index()
        {

            return "Account Created";
        }

        // GET: user/Create
        public ActionResult Create()
        {
            return View(new user());
        }

        // POST: user/Create
        [HttpPost]
        public ActionResult Create(user userModel)
        {
            try
            {
                using (seesharpEntities sharp = new seesharpEntities())
                {
                    sharp.users.Add(userModel);
                    sharp.SaveChanges();
                }

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}