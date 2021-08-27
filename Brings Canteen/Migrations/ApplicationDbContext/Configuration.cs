namespace Brings_Canteen.Migrations.ApplicationDbContext
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Brings_Canteen.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ApplicationDbContext";
        }
        protected override void Seed(Brings_Canteen.Models.ApplicationDbContext context)
        {

            List<Category> categoryList = new List<Category>
            {
                new Category {ID = 1,  Name = "Snacks" },
                new Category {ID = 2,  Name = "Light Meal"},
                new Category {ID = 3,  Name = "Soup"},
                new Category {ID = 4,  Name = "Chicken" },
                new Category {ID = 5,  Name = "Meat" }

            };

            categoryList.ForEach(category => context.Categories.AddOrUpdate(cat => cat.Name,category));
            context.SaveChanges();

            List<FoodItem> foodList = new List<FoodItem>
            {
                new FoodItem { ID = GetNewUid(), CategoryID = 1, isEnabled = true, Name = "Meat Pie", Price = 3.00m, Discriminator = "FoodItem" },
                new FoodItem { ID = GetNewUid(),  CategoryID = 2, isEnabled = true, Name = "Fried Rice", Price = 4.00m , Discriminator = "FoodItem"},
                new FoodItem { ID = GetNewUid(),  CategoryID = 2, isEnabled = true, Name = "Jollof Rice", Price = 4.00m , Discriminator = "FoodItem"},
                new FoodItem { ID = GetNewUid(),  CategoryID = 5, isEnabled = true, Name = "Meat Pepper Soup", Price = 3.00m, Discriminator = "FoodItem"},
                new FoodItem { ID = GetNewUid(),  CategoryID = 2, isEnabled = true, Name = "Spaghetti", Price = 5.00m , Discriminator = "FoodItem"},
                new FoodItem { ID = GetNewUid(),  CategoryID = 2, isEnabled = true, Name = "White Rice", Price = 5.00m , Discriminator = "FoodItem"},
                new FoodItem { ID = GetNewUid(),  CategoryID = 4, isEnabled = true, Name = "Fried Chicken", Price = 7.00m, Discriminator = "FoodItem"},
                new FoodItem { ID = GetNewUid(),  CategoryID = 4, isEnabled = true, Name = "Grilled Chicken", Price = 7.00m, Discriminator = "FoodItem"},
                new FoodItem { ID = GetNewUid(),  CategoryID = 1, isEnabled = true, Name = "Ice Cream", Price = 2.00m, Discriminator = "FoodItem"}
            };

            foodList.ForEach(food => context.FoodItems.AddOrUpdate(fd => fd.Name, food));

            context.SaveChanges();
        }
        private string GetNewUid()
        {
            return Guid.NewGuid().ToString();
        }

    }
}
