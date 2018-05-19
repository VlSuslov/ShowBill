using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShowBill.Data;
using ShowBill.Logic;
using ShowBill.Models;

namespace ShowBill.Controllers
{
    public class HomeController : Controller
    {
        private readonly IShowBillUnitOfWork uoW;

        public HomeController(IShowBillUnitOfWork uoW)
        {
            this.uoW = uoW;
        }

        public IActionResult Index()
        {
            var model = new MainModel()
            {
                Filter = new FilterModel(),
                Events = new List<EventViewModel>()
                {
                    new EventViewModel
                    {
                        Photo="/images/banner1.svg",
                        Title ="Event",
                        Place="Place",
                        Date="01.01.18"
                    },
                    new EventViewModel
                    {
                        Photo="/images/banner2.svg",
                        Title ="Event",
                        Place="Place Place Place Place Place Place Place Place",
                        Date="01.01.18"
                    },
                    new EventViewModel
                    {
                        Photo="/images/banner3.svg",
                        Title =" Event Event Event Event Event Event Event",
                        Place="Place",
                        Date="01.01.18"
                    }
                }
            };
            return View("../Main", model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
