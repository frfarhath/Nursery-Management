using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using UserManagementApp.Models;

namespace UserManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private static List<User> _users = new List<User>
        {
            new User { Id = 1, Username = "Alice", Password = "pass1", Role = "Admin" },
            new User { Id = 2, Username = "Bob", Password = "pass2", Role = "User" },
            new User { Id = 3, Username = "Charlie", Password = "pass3", Role = "Manager" }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(_users);
        }

        // GET: /Home/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Home/Create
        [HttpPost]
        public IActionResult Create(User newUser)
        {
            newUser.Id = _users.Any() ? _users.Max(u => u.Id) + 1 : 1;
            _users.Add(newUser);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            return View(user);
        }

        public IActionResult Edit(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            var user = _users.FirstOrDefault(u => u.Id == updatedUser.Id);
            if (user == null) return NotFound();

            // Preserve Username (readonly in UI)
            user.Username = updatedUser.Username;

            // Preserve existing password (no change here)
            // user.Password = user.Password;

            // Update only the Role
            user.Role = updatedUser.Role;

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = _users.FirstOrDefault(u => u.Id == id);
            if (user != null) _users.Remove(user);
            return RedirectToAction("Index");
        }

        // Add this Privacy action
        public IActionResult Privacy()
        {
            return View();  // Returns Views/Home/Privacy.cshtml
        }
    }
}
