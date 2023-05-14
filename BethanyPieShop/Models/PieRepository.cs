using Microsoft.EntityFrameworkCore;

namespace BethanyPieShop.Models
{
    public class PieRepository:IPieRepository
    {
        private readonly BethanyPieShopDBContext _bethanyPieShopDBContext;

        public PieRepository(BethanyPieShopDBContext bethanyPieShopDBContext)
        {
            _bethanyPieShopDBContext = bethanyPieShopDBContext;
        }

        public IEnumerable<Pie> AllPies
        {
            get
            {
                return _bethanyPieShopDBContext.Pies.Include(c => c.Category);
            }
        }

        public IEnumerable<Pie> PiesOfTheWeek
        {
            get
            {
                return _bethanyPieShopDBContext.Pies.Include(c => c.Category).Where(p=>p.IsPieOfTheWeek);
            }
        }

        public Pie? GetPieById(int pieId)
        {
            return _bethanyPieShopDBContext.Pies.FirstOrDefault(p => p.PieId == pieId); 
        }
    }
}
