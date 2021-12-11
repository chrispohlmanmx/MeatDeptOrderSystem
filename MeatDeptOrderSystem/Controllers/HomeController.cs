using MeatDeptOrderSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Controllers
{
    public class HomeController : Controller
    {
        private OrderContext context { get; set; }

        public HomeController(OrderContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            var items = context.OrderItems.OrderBy(oi => oi.ItemName).ToList();
            return View(items);
        }
    }
}
