using MecanicNew.DTOs;
using MecanicNew.Enums;
using MecanicNew.Model;
using MecanicNew.SqlData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Net;

namespace MecanicNew.Controllers
{
    public class CarSelectController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarSelectController(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Car()
        {
            var CarNumber = _context.
                Cars.
                Select(c => new CarDto()
                {
                    CarId = c.Id,
                    CarName = c.Name
                }).ToList();

            var CarOwner = _context.
                CarOwners.
                Select(c => new CarOwnerDto()
                {
                    CarOwnerId = c.Id,
                    CarOwnerName = c.Name
                }).ToList();

            var Driver = _context.
                Drivers.
                Select(c => new DriverDto()
                {
                    DriverId = c.Id,
                    DriverName = c.Name
                }).ToList();

            var Mecanic = _context.
                Users.
                Where(c => c.UserRoleId == (int)UserRoleEnum.Admin || c.UserRoleId == (int)UserRoleEnum.Mecanic).
                Select(c => new UserDto()
                {
                    UserId = c.Id,
                    UserName = c.Name,
                }).ToList();




            RepairSelectVm repairSelectVm = new RepairSelectVm();

            repairSelectVm.Cars = CarNumber;
            repairSelectVm.Owner = CarOwner;
            repairSelectVm.Drivers = Driver;
            repairSelectVm.Users = Mecanic;

            return View(repairSelectVm);

        }
        [HttpPost]
        public IActionResult AddCar(DateTime CarDate, RepairSelectVm request)
        {

            RepairSelects repairSelect = new RepairSelects();
            repairSelect.AddTime = CarDate;
            repairSelect.CarId = request.AddCar.CarId;
            repairSelect.DriverId = request.AddCar.DriverId;
            repairSelect.CarOwnerId = request.AddCar.CarOwnerId;
            repairSelect.UserId = request.AddCar.UserId;

            _context.RepairSelects.Add(repairSelect);
            _context.SaveChanges();


            return RedirectToAction("Repair", "Repair", new { repairSelect.Id});
        }

        [HttpGet]
        public IActionResult AddCarNumber()
        {
            var CarOwner = _context.
                CarOwners.
                Select(c => new CarOwnerDto()
                {
                    CarOwnerId = c.Id,
                    CarOwnerName = c.Name
                }).ToList();

            RepairSelectVm repairSelectVm = new RepairSelectVm();

            repairSelectVm.Owner = CarOwner;

            return View(repairSelectVm);
        }

        [HttpPost]
        public IActionResult AddCarNumberSql(string CarName)
        {
            Car cars = new Car();
            cars.Name = CarName;
            cars.CreatedDate = DateTime.Now;

            _context.Cars.Add(cars);
            _context.SaveChanges();

            return RedirectToAction("Car", "CarSelect");
        }

    }
}
