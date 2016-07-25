using mvc6_example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace mvc6_example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomeModel
            {
                Greeting = "World!!!",
                Statuses = new List<Status>
                {
                    new Status
                    {
                        Message = "Success",
                        Style = StatusClass.SUCCESS
                    },
                    new Status
                    {
                        Message = "Better luck next time ;)",
                        Style = StatusClass.WARNING
                    },
                    new Status
                    {
                        Message = "WTF!",
                        Style = StatusClass.DANGER
                    },
                    new Status
                    {
                        Message = "Nice!",
                        Style = StatusClass.SUCCESS
                    },
                    new Status
                    {
                        Message = "Try, try again >:(",
                        Style = StatusClass.WARNING
                    }
                }
            };

            return View(model);
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
