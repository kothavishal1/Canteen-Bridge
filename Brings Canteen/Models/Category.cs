using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Brings_Canteen.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }


        public ICollection<FoodItem> foodList { get; set; }
    }
}