using ETA.Models;
using ETA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETA.Controllers
{
    public class WineController : Controller
    {
        

        public WineController()
        {
            
        }
        // GET: Wine
        public ActionResult Index()
        {
            
            return View();
        }
    }
}