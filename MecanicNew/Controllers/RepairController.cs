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

        public RepairController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Repair( int id)
        {
            TempData["CarSelectId"] = id;
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
            RepairDesciription repair = new RepairDesciription();
            repair.RepairId = Convert.ToInt32(TempData["CarSelectId"].ToString());
            repair.Type = remontType;
            repair.RepairDesc = remontText;
            repair.RepairCount = remontCount;
            repair.RepairPrice = remontPrice;
            repair.RepairTotalPrice = remontTotalPrice;





            _context.RepairDesciription.AddAsync(repair);
            _context.SaveChangesAsync();

            return Json(new
            {
                status = HttpStatusCode.OK,
                data = repair
            });

    }
    }
}
