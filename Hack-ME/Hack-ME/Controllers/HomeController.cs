using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hack_ME.Models;
using Microsoft.AspNetCore.Identity;

namespace Hack_ME.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public HomeController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult RyanThing()
        {
            return View();
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated) {
                var daUser = await _userManager.GetUserAsync(User);
                if (daUser.studentID != null) {
                    return View("StudentHome");
                }
                if (daUser.teacherID != null) {
                    return View("TeacherHome");
                }
            }
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
