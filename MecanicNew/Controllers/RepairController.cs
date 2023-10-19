using MecanicNew.DTOs;
using MecanicNew.Model;
using MecanicNew.Request;
using MecanicNew.SqlData;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace MecanicNew.Controllers
{
    public class RepairController : Controller
    {
        private readonly ApplicationDbContext _context;
        static int repairstatcId = 0;

        public RepairController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Repair(int id)
        {
            TempData["CarSelectId"] = id;
            repairstatcId = id;
            var type = _context.Types.Select(c => new TypeDto()
            {
                TypeId = c.Id,
                TypeName = c.Name

            }).ToList();

            return View(type);
        }

        [HttpPost]
        public async Task<JsonResult> AddRemont(string remontType, string remontText, int remontCount, int remontPrice, int remontTotalPrice)
        {

            //var RepairPageId = Convert.ToInt32(TempData["CarSelectId"].ToString());
            RepairDesciription repair = new RepairDesciription();
            repair.RepairId = repairstatcId ;
            repair.Type = remontType;
            repair.RepairDesc = remontText;
            repair.RepairCount = remontCount;
            repair.RepairPrice = remontPrice;
            repair.RepairTotalPrice = remontTotalPrice;





             _context.RepairDesciription.Add(repair);
             _context.SaveChanges();

            return Json(new
            {
                status = HttpStatusCode.OK,
                data = repair
            });

        }

        [HttpPost]
        public JsonResult TotalPriceSql(int toplam)
        {
            RepairTotalPrices total = new RepairTotalPrices();
            total.RepairId = repairstatcId;
            total.Price = toplam;
            total.CreatedDate = DateTime.Now;

            _context.RepairTotalPrices.Add(total);
            _context.SaveChanges();

            return Json(new
            {
                status = HttpStatusCode.OK,
                data = toplam
            });
        }
    }
}
