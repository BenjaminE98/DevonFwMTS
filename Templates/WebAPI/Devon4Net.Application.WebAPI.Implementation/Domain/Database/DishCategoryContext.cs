using Devon4Net.Application.WebAPI.Implementation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devon4Net.Application.WebAPI.Implementation.Domain.Database
{
    public class DishCategoryContext : DbContext
    {
        public DishCategoryContext(DbContextOptions<DishCategoryContext> options)
            : base(options)
        {
        }


        public virtual DbSet<DishCategory> DishCategory { get; set; }
    }
}