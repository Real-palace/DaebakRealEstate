using Microsoft.AspNetCore.Mvc;
using DaebakRealEstate.Models;
using System.Linq;

namespace DaebakRealEstate.Controllers
{
    public class UserManagementController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserManagementController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ✅ Show User List with Search & Filter
        public IActionResult Index(string search, string role)
        {
            var users = _context.Users.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                users = users.Where(u => u.Name.Contains(search) || u.Email.Contains(search));
            }

            if (!string.IsNullOrEmpty(role) && role != "All")
            {
                users = users.Where(u => u.Role == role);
            }

            return View("~/Views/Management/UserManagement.cshtml", users.ToList());
        }

        // ✅ Show Add User Form
        public IActionResult AddUser()
        {
            return View("~/Views/Management/AddUser.cshtml");
        }

        // ✅ Handle Add User Form Submission
        [HttpPost]
        public IActionResult AddUser(UserViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(newUser);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("~/Views/Management/AddUser.cshtml", newUser);
        }

        // ✅ Show Edit User Form
        public IActionResult EditUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();

            return View("~/Views/Management/EditUser.cshtml", user);
        }

        // ✅ Handle Edit User Form Submission
        [HttpPost]
        public IActionResult EditUser(UserViewModel updatedUser)
        {
            var user = _context.Users.Find(updatedUser.Id);
            if (user == null) return NotFound();

            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            user.Role = updatedUser.Role;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // ✅ Delete User
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
