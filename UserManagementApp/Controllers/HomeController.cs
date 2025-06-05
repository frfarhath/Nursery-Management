using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;
using UserManagementApp.Data;
using UserManagementApp.Models;
using Microsoft.EntityFrameworkCore;

namespace UserManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var users = _db.Users.ToList();
            // No need to copy TempData to ViewBag
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User newUser)
        {
            if (!ModelState.IsValid)
            {
                return View(newUser);
            }

            _db.Users.Add(newUser);
            _db.SaveChanges();

            TempData["SuccessMessage"] = $"User '{newUser.Username}' created successfully!";
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var user = _db.Users.Find(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            if (!ModelState.IsValid)
            {
                return View(updatedUser);
            }

            var user = _db.Users.Find(updatedUser.Id);
            if (user == null) return NotFound();

            user.Username = updatedUser.Username;
            user.Role = updatedUser.Role;

            // Uncomment to allow password editing
            // user.Password = updatedUser.Password;

            _db.Entry(user).State = EntityState.Modified;
            _db.SaveChanges();

            TempData["SuccessMessage"] = $"User '{updatedUser.Username}' updated successfully!";
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var user = _db.Users.Find(id);
            if (user == null) return NotFound();
            return View(user);
        }

        public IActionResult Delete(int id)
        {
            var user = _db.Users.Find(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = _db.Users.Find(id);
            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
                TempData["SuccessMessage"] = $"User '{user.Username}' deleted successfully!";
            }
            return RedirectToAction("Index");
        }
    }
}
