using Microsoft.EntityFrameworkCore;

namespace BethanyPieShop.Models
{
    public class BethanyPieShopDBContext:DbContext
    {
        public BethanyPieShopDBContext(DbContextOptions<BethanyPieShopDBContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
