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
            var model = TestShortModel.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View(MVC.Shared.Views.Error);
        }

        public virtual ActionResult Details(int id)
        {
            var model = TestModel.Get(id);
            return View(model);
        }

        [HttpPost]
        public virtual ActionResult Details(FormCollection form)
        {
            return View();
        }
    }
}
