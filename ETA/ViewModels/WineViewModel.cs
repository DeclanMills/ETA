using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETA.ViewModels
{
    public class WineViewModel
    {
        public Guid Id { get; set; }
        public int CategoryId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public HttpPostedFileBase ImagePath { get; set; }

        public IEnumerable<SelectListItem> selectListItems { get; set; }
    }
}