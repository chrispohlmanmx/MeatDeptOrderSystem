using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Models
{
    public class OrderItemViewModel
    {
        public OrderItemViewModel()
        {
            CurrentOrder = new OrderItem();
        }
        public Filters Filters { get; set; }

        public List<Status> Statuses { get; set; }
        public List<Location> Locations { get; set; }
        public Dictionary<string, string> DueFilters { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public OrderItem CurrentOrder { get; set; }
    }
}
