namespace BethanyPieShop.Models
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly BethanyPieShopDBContext _bethanyPieShopDBContext;

        public CategoryRepository(BethanyPieShopDBContext bethanyPieShopDBContext)
        {
            _bethanyPieShopDBContext = bethanyPieShopDBContext;
        }

        public IEnumerable<Category> AllCategories => _bethanyPieShopDBContext.Categories.OrderBy(p => p.CategoryName);
    }
}
