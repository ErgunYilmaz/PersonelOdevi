using PersonelOdevi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonelOdevi.Controllers
{
    public class ForExampleController : Controller
    {
        ForExampleDBEntities db = new ForExampleDBEntities();
        public ActionResult Index()
        {
            List<User> users = db.Users.ToList();
            return View(users);
        }
        public ActionResult Update(int id)
        {
            User user=db.Users.Find(id);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {

            var user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



    }