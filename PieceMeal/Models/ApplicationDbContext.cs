using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace PieceMeal.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Client> Clients { get; set; }
        //public DbSet<ClientRecipe> ClientRecipes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Cuisine> Cusines { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}