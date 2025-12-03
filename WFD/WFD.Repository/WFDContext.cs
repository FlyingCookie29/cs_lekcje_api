using Microsoft.EntityFrameworkCore;
using WFD.Model.BaseModel;

namespace WFD.Repository
{    
        public class WFDContext : DbContext
        {
            public WFDContext(DbContextOptions<WFDContext> options) : base(options)
            { }
            
            public DbSet<Dish> Dishes { get; set; }
            public DbSet<Ingredient> Ingredients { get; set; }

            
        }
}