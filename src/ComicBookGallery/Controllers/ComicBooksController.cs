using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    //public is default option - needs to be otherwise it can't be found
    public class ComicBooksController : Controller
    {
        //now add an 'action' method - every method on a controller is an action method
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");

            }
            return Content("Hello from the comic books controller!");
          
        }
    }
}
