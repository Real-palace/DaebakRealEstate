using Microsoft.AspNetCore.Mvc;
using DaebakRealEstate.Models;
using System.Linq;
using System.Collections.Generic;

public class UserController : Controller
{
    private readonly ApplicationDbContext _context;

    public UserController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult UserList()
    {
        // ✅ Convert List<User> to List<UserViewModel>
        List<UserViewModel> userViewModels = _context.Users
            .Select(u => new UserViewModel
            {
                Id = u.UserId,  // Ensure UserId exists in User Model
                Username = u.Username,
                Email = u.Email,
                FirstName = u.FirstName,
                LastName = u.LastName,
                PhoneNumber = u.PhoneNumber,
                HouseNumber = u.HouseNumber,
                Role = u.Role
            })
            .ToList();

        return View(userViewModels); // ✅ Pass List<UserViewModel> to View
    }
}
