using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLOGCORE2022.Controllers
{
    public class NewsLetterController : Controller
    {
        //NewsLetterManager
        public IActionResult Index()
        {
            return View();
        }
    }
}
