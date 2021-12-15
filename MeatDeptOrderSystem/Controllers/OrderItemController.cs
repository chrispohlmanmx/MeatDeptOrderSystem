using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeatDeptOrderSystem.Models;
using Microsoft.AspNetCore.Authorization;

namespace MeatDeptOrderSystem.Controllers
{
    
    [Authorize]
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

        [HttpGet]
        public IActionResult Edit(int OrderItemId)
        {
            ViewBag.Action = "Edit";
            OrderItem item = context.OrderItems.Find(OrderItemId);
            OrderItemViewModel model = new OrderItemViewModel(item);
            model.Statuses = context.Statuses.ToList();
            model.Locations = context.Locations.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(OrderItemViewModel item)
        {
            if (ModelState.IsValid)
            {
                context.OrderItems.Update(item.SelectedItem);  
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (item.SelectedItem.OrderItemId == 0) ? "Add" : "Edit";
                return View(item);
            }
        }
        [HttpGet]
        public IActionResult Details(int id)
        {

            var orderitem = context.OrderItems.Find(id);
            orderitem.Status = context.Statuses.Find(orderitem.StatusId);
            orderitem.Location = context.Locations.Find(orderitem.LocationId);
            return View(orderitem);
        }

        [HttpGet]
        public IActionResult Pull(int id)
        {
            OrderItem item = context.OrderItems.Find(id);
            OrderItemViewModel model = new OrderItemViewModel(item);
            model.Locations = context.Locations.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Pull(OrderItemViewModel item)
        {
            //update just the relevant fields
            context.OrderItems.Attach(item.SelectedItem);
            context.Entry(item.SelectedItem).Property(x => x.LocationId).IsModified = true;
            context.Entry(item.SelectedItem).Property(x => x.StatusId).IsModified = true;
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
