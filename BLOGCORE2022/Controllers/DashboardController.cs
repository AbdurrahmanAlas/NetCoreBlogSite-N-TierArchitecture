using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLOGCORE2022.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {


            Context c = new Context();

            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v3 = c.Categories.Count();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterID == 1).Count();
            return View();
        }
    }
}
