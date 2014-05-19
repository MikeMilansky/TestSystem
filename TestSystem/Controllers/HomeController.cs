using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSystem.Models;

namespace TestSystem.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            var model = ShortTest.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View(MVC.Shared.Views.Error);
        }

        public virtual ActionResult Details(int id)
        {
            var model = Test.Get(id);
            return View(model);
        }

        public virtual ActionResult Demo()
        {
            var model = new Demo { ID = 1, Title = "myTitle", myList = new List<string> { "1", "2", "3" } };
            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Details(Answer answer)
        {
            var answ = answer;
            return View();
        }
    }
}
