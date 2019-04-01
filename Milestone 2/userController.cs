using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegLog.Models;

namespace RegLog.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public ActionResult Index()
        {
            List<user> userList = new List<user>();
            using (seesharpEntities sharp= new seesharpEntities())
            {
                userList = sharp.users.ToList<user>();
            }
            return View(userList);
        }

        // GET: user/Details/5
        public ActionResult Details(int id)
        {
            return View();
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

        // GET: user/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: user/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: user/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: user/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
