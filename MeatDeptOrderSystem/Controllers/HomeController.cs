using MeatDeptOrderSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Index(string id)
        {
            var model = new OrderItemViewModel();
            var filters = new Filters(id);
            model.Filters = filters;
            model.Statuses = context.Statuses.ToList();
            model.Locations = context.Locations.ToList();
            model.DueFilters = Filters.DueFilterValues;
            IQueryable<OrderItem> query = context.OrderItems.Include(oi => oi.Location).Include(oi => oi.Status);
            if (filters.HasLocation)
            {
                query = query.Where(t => t.LocationId == filters.LocationId);
            }
            if (filters.HasStatus)
            {
                query = query.Where(t => t.StatusId == filters.StatusId);
            }
            if (filters.HasDue)
            {
                var today = DateTime.Today;
                if (filters.IsPast)
                    query = query.Where(t => t.pickupDate < today);
                else if (filters.IsFuture)
                    query = query.Where(t => t.pickupDate > today);
                else if (filters.IsToday)
                    query = query.Where(t => t.pickupDate == today);
            }
            var items = query.OrderBy(oi => oi.pickupDate).ToList();
            model.OrderItems = items;
            return View(model);
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }
    }
}
