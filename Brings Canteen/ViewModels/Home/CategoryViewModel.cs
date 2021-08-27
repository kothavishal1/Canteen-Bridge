using Brings_Canteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Brings_Canteen.ViewModels.Home
{
    public class CategoryViewModel
    {
        public ICollection<Category> Category { get; set; }
        public ICollection<FoodItem> foodList { get; set; }
    }
}