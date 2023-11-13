using MecanicNew.DTOs;
using MecanicNew.Model;
using MecanicNew.SqlData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace MecanicNew.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(bool data)
        {
            bool check = data;
            var Repairs = _context.RepairSelects
                .Select(c => new RepairDto
            {
                CarNumber = c.Car.Name.ToString(),
                CarOwner = c.Owner.Name.ToString(),
                Mecanic = c.User.Name,
                DateTime = c.AddTime,
                  
            }).ToList();
            IndexPageVm vm = new IndexPageVm();
            vm.Repair = Repairs;
            if(check == true)
            {
            var ri =_context.RepairSelects.LastOrDefault().Id;
            var TotalPrice = _context.RepairTotalPrices.Where(x=>x.RepairId == ri).FirstOrDefault();
            vm.Price = TotalPrice.Price;
            }

            return View(vm);
        }
    }
}
