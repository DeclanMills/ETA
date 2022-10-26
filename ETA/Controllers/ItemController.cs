using ETA.Models;
using ETA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETA.Controllers
{
    public class ItemController : Controller
    {

        private BWCDBEntities objBWCDBEntities;

        public ItemController()
        {
            objBWCDBEntities = new BWCDBEntities();
        }

        // GET: Item

        public ActionResult Index()
        {
            WineViewModel objWineViewModel = new WineViewModel();
            objWineViewModel.selectListItems = (from objCat in objBWCDBEntities.Wines
                                                select new SelectListItem()
                                                {
                                                    Text = objCat.CategoryName,
                                                    Value = objCat.CategoryId.ToString(),
                                                    Selected = true
                                                });
            return View(objWineViewModel);
        }

        [HttpPost]
        public JsonResult Index(WineViewModel objWineViewModel)
        {
            return Json("HHHH", JsonRequestBehavior.AllowGet);
        }
    }
}