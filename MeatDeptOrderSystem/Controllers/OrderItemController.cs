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
            ViewBag.Action = "Add";
            return View("Edit", new OrderItem());
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
                if (item.OrderItemId == 0)
                {
                    item.setStatus();
                    context.OrderItems.Add(item);
                    
                }
                else
                {
                    item.setStatus();
                    context.OrderItems.Update(item);
                    
                }
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
            var item = context.OrderItems.Find(id);
            return View(item);
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
            context.OrderItems.Attach(item);
            context.Entry(item).Property(x => x.LocatedIn).IsModified = true;
            context.Entry(item).Property(x => x.IsReady).IsModified = true;
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
