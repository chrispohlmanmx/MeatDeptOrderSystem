using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeatDeptOrderSystem.Models
{
    //I don't think this will work until I implement some Interfaces for my model 
    [HtmlTargetElement("td", Attributes = "my-status")]
    public class StatusLineTagHelper : TagHelper
    {
        private OrderItem item;
        public StatusLineTagHelper(OrderItem i) => item = i;

        public bool MyStatus { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            item.setStatus();

            switch (item.Status)
            {
                
                    case "Order Placed":
                    output.Attributes.Add("class", "bg-info");
                        break;
                    case "Ready":
                    output.Attributes.Add("class", "bg-success");
                    break;
                    case "Complete":
                    output.Attributes.Add("class", "bg-secondary");
                    break;
                    case "Overdue":
                    output.Attributes.Add("class", "bg-danger");
                    break;
                    case "On Order":
                    output.Attributes.Add("class", "bg-warning");
                    break;
            }
        }
    }
}
