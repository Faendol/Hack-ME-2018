using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hack_ME.Data;
using Hack_ME.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Hack_ME.Controllers
{
    public class ApiController : Controller
    {
        private readonly ApplicationDbContext _DB;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApiController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _DB = db;
        }

        [HttpGet]
        public string Check()
        {
            return "Good!";
        }

        [HttpPost]
        public async Task<string> checkRoom(int id)
        {
            var location = _DB._locations.First(e => e.LocationID == id);
            if (location != null) {
                var poison = await _userManager.GetUserAsync(User);
                var studentFor = _DB._students.Where(e => e.StudentID == poison.studentID.Value + Int32.MinValue);
                studentFor.First().LocationID = location.LocationID;
                _DB.SaveChanges();

                return "Room: " + location.LocationName;
            }
            else {
                return "Failed to Scan or Incorrect Code";
            }
        }

        [HttpPost]
        public int newLocation(string name)
        {
            var locaz = new Location() { LocationName = name };
            _DB._locations.Add(locaz);
            _DB.SaveChanges();

            return locaz.LocationID;
        }
    }
}