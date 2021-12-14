using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeatDeptOrderSystem.Models;

namespace MeatDeptOrderSystem.Controllers
{
    public class OrderItemController : Controller
    {
        private OrderContext context { get; set; }

        public OrderItemController(OrderContext ctx) => context = ctx;


        [HttpGet]
        public IActionResult Add()
        {
            var model = new OrderItemViewModel();
            model.Locations = context.Locations.ToList();
            model.Statuses = context.Statuses.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(OrderItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                context.OrderItems.Add(model.CurrentOrder);   
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                model.Locations = context.Locations.ToList();
                model.Statuses = context.Statuses.ToList();
                return View(model);
            }
        }

        public IActionResult Edit(int OrderItemId)
        {
            ViewBag.Action = "Edit";
            var item = context.OrderItems.Find(OrderItemId);
            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(OrderItem item)
        {
            if (ModelState.IsValid)
            {
                context.OrderItems.Update(item);  
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (item.OrderItemId == 0) ? "Add" : "Edit";
                return View(item);
            }
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var orderitem = context.OrderItems.Find(id);
            return View(orderitem);
        }

        [HttpGet]
        public IActionResult Pull(int id)
        {
            var item = context.OrderItems.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Pull(OrderItem item)
        {
            //update just the relevant fields
            context.OrderItems.Attach(item);
            context.Entry(item).Property(x => x.LocationId).IsModified = true;
            context.Entry(item).Property(x => x.StatusId).IsModified = true;
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Complete(int id)
        {
            var item = context.OrderItems.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Complete(OrderItem item)
        {
            context.OrderItems.Attach(item);
            context.Entry(item).Property(x => x.StatusId).IsModified = true;
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Delete (int id)
        {
            var item = context.OrderItems.Find(id);
            return View(item);
        }

        [HttpPost]
        public IActionResult Delete(OrderItem item)
        {
            context.OrderItems.Remove(item);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


        
    }
}
