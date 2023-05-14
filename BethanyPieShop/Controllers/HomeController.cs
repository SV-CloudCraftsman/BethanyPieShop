using BethanyPieShop.Models;
using BethanyPieShop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var PiesOfTheWeek = _pieRepository.PiesOfTheWeek;
            var HomeViewModel = new HomeViewModel(PiesOfTheWeek);
            return View(HomeViewModel);
        }
    }
}
