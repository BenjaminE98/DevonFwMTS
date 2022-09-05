using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Devon4Net.Application.WebAPI.Implementation.Domain.Entities
{
public partial class Dish
    {
        public Dish()
        {
            Categories = new List<Category>();
            //DishIngredient = new List<DishIngredient>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public Image Image { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
