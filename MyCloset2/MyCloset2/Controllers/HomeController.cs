using MyCloset2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyClosetApp.Controllers
{
    public class HomeController : Controller
    {
        private MyCloset2Context db = new MyCloset2Context(); //adds the database context to the controller

        public List<IPhotoGiver> GetListofAllItems ()  //This method takes all the DB files from the other models and adds them to one list
        {
            List<IPhotoGiver> allItems = new List<IPhotoGiver>();
            allItems.AddRange(db.Tops.ToList());
            allItems.AddRange(db.Bottoms.ToList());
            allItems.AddRange(db.Accessories.ToList());
            allItems.AddRange(db.Shoes.ToList());

            return allItems;
        }

        public ActionResult Index() //Used on the homepage to be able to have the carousel display photos from all models
        {
            List <IPhotoGiver> allItems = GetListofAllItems();

            return View(allItems);
        }
        public ActionResult Spring()  //Used on the spring page, accessible from the homepage spring thumbnail
        {
            List<IPhotoGiver> allItems = GetListofAllItems();

            return View(allItems);
        }
        public ActionResult Summer() //Summer thumbnail
        {
            List<IPhotoGiver> allItems = GetListofAllItems();
            return View(allItems);
        }
    }
}