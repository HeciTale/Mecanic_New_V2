﻿using MecanicNew.DTOs;
using MecanicNew.Model;
using MecanicNew.SqlData;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {

            var Repairs = _context.RepairSelects.Select(c => new RepairDto
            {
                CarNumber = c.Car.Name.ToString(),
                CarOwner = c.Owner.Name.ToString(),
                Mecanic = c.User.Name,
                DateTime = c.AddTime,
                


                
            }).ToList();
            

            return View(Repairs);
        }
    }
}
