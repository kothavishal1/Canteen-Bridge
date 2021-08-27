﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Brings_Canteen.Models
{
    public class FoodItem
    {

        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Currency, ErrorMessage = "You did not enter a valid currency value ex. $15.6")]
        public decimal Price { get; set; }

        [ScaffoldColumn(false)]
        public bool? isEnabled { get; set; }

        [ForeignKey("Category")]
        public int? CategoryID { get; set; }

        public Category Category { get; set; }
        
        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

        [NotMapped]
        public string CartItemId { get; set; }

    }
}