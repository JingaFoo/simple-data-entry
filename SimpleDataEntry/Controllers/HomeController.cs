using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleDataEntry.Models;

namespace SimpleDataEntry.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [Route("/rsvpform")]
        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}
