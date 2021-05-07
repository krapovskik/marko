using MVCMyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMyApp.Controllers
{
    public class FriendController : Controller
    {
        // GET: Friend

        static List<Friend> friends = new List<Friend>()
        {
            new Friend { FixId = 0, Id = 0, Name = "Kosta",Place = "Tetovo"},
            new Friend { FixId = 1, Id = 1, Name = "Acika",Place = "Kamenica"},
            new Friend { FixId = 2, Id = 2, Name = "Ivan",Place = "Delchevo"},

        };

        public ActionResult Index()
        {
            return View(friends);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult New(Friend friend)
        {
            friend.Id = friends.Select(f => f.Id).Max() + 1;
            friends.Add(friend);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Friend friend_temp = friends.Where(friend => friend.Id == id).FirstOrDefault();
            return View(friend_temp);
        }

        [HttpPost]
        public ActionResult Update(Friend friend)
        {
            int fixid = friend.FixId;
            int id = friend.Id;
            string name = friend.Name;
            string place = friend.Place;

            Friend temp = friends.Where(f => f.Id == id).FirstOrDefault();
            temp.FixId = fixid;
            temp.Name = name;
            temp.Place = place;

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            friends.Remove(friends.Find(friend => friend.Id == id));
            return RedirectToAction("Index");
        }
    }
}