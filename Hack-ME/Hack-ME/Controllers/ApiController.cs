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
    [Produces("application/json")]
    [Route("api/Api")]
    public class ApiController : Controller
    {
        private readonly ApplicationDbContext _DB;
        private readonly UserManager<ApplicationUser> _userManager;

        public ApiController(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
            _DB = db;
        }

        [HttpPost]
        public async Task<string> CheckRoom(int roomID)
        {
            var location = _DB._locations.First(e => e.LocationID == roomID);
            if (location != null) {
                var poison = await _userManager.GetUserAsync(User);
                _DB._students.First(e => e.StudentID == poison.studentID).LocationID = location.LocationID;
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