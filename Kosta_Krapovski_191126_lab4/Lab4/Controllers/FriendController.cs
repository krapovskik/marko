using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class FriendController : Controller
    {
        private FriendContext context;
        // GET: Friend
        public FriendController()
        {
            context = new FriendContext();
        }
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
        public ActionResult Index()
        {
            return View(context.friends.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateNew(Friend friend)
        {
            context.friends.Add(friend);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var friend = context.friends.Single(f => f.Id == id);
            if (friend == null)
            {
                return HttpNotFound();
            }
            return View(friend);
        }

        [HttpPost]
        public ActionResult Update(Friend friend)
        {
            var friendInDb = context.friends.Single(f => f.Id == friend.Id);
            TryUpdateModel(friendInDb);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Friend friend = context.friends.Find(id);
            context.friends.Remove(friend);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}