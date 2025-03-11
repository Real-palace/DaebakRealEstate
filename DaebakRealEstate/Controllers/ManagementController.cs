using Microsoft.AspNetCore.Mvc;
using DaebakRealEstate.Models;
using System.Collections.Generic;
using System.Linq;

namespace DaebakRealEstate.Controllers
{
    public class ManagementController : Controller
    {
        private static List<UserViewModel> Users = new List<UserViewModel>
        {
            new UserViewModel { Id = 1, Name = "John Doe", Email = "john@example.com", Role = "Admin" },
            new UserViewModel { Id = 2, Name = "Jane Smith", Email = "jane@example.com", Role = "User" }
        };

        // Display Management Page with Search & Filter
        public IActionResult Management(string search = "", string role = "")
        {
            var filteredUsers = Users.Where(u =>
                (string.IsNullOrEmpty(search) || u.Name.Contains(search, System.StringComparison.OrdinalIgnoreCase) || u.Email.Contains(search, System.StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(role) || u.Role.Equals(role, System.StringComparison.OrdinalIgnoreCase))
            ).ToList();

            return View("Management", filteredUsers);
        }

        // Display Add User Form
        public IActionResult AddUser() => View();

        // Process New User Form
        [HttpPost]
        public IActionResult AddUser(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = Users.Any() ? Users.Max(u => u.Id) + 1 : 1;
                Users.Add(model);
                return RedirectToAction("Management");
            }
            return View(model);
        }

        // Display Edit User Form
        public IActionResult EditUser(int id)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            return user == null ? NotFound() : View(user);
        }

        // Process Edit User Form
        [HttpPost]
        public IActionResult EditUser(UserViewModel model)
        {
            var user = Users.FirstOrDefault(u => u.Id == model.Id);
            if (user != null)
            {
                user.Name = model.Name;
                user.Email = model.Email;
                user.Role = model.Role;
                return RedirectToAction("Management");
            }
            return NotFound();
        }

        // Delete User
        public IActionResult DeleteUser(int id)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                Users.Remove(user);
                return RedirectToAction("Management");
            }
            return NotFound();
        }
    }
}
