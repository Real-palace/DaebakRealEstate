using Microsoft.AspNetCore.Mvc;
using DaebakRealEstate.Models;
using System.Linq;

namespace DaebakRealEstate.Controllers
{
    public class ManagementController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ManagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ Display Management Page with Search & Filter
        public IActionResult Management(string search = "", string role = "")
        {
            var users = _context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                users = users.Where(u => u.Name.Contains(search) || u.Email.Contains(search));
            }

            if (!string.IsNullOrEmpty(role))
            {
                users = users.Where(u => u.Role == role);
            }

            return View("Management", users.ToList());
        }

        // ✅ Display Add User Form
        public IActionResult AddUser() => View();

        // ✅ Process New User Form
        [HttpPost]
        public IActionResult AddUser(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Management");
            }
            return View(model);
        }

        // ✅ Display Edit User Form
        public IActionResult EditUser(int id)
        {
            var user = _context.Users.Find(id);
            return user == null ? NotFound() : View(user);
        }

        // ✅ Process Edit User Form
        [HttpPost]
        public IActionResult EditUser(UserViewModel model)
        {
            var user = _context.Users.Find(model.Id);
            if (user != null)
            {
                user.Name = model.Name;
                user.Email = model.Email;
                user.Role = model.Role;
                _context.SaveChanges();
                return RedirectToAction("Management");
            }
            return NotFound();
        }

        // ✅ Delete User
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
                return RedirectToAction("Management");
            }
            return NotFound();
        }
    }
}
