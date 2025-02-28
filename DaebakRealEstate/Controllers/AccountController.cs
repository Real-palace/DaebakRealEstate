using Microsoft.AspNetCore.Mvc;
using DaebakRealEstate.Models;

public class AccountController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        return View(); // Looks for Views/Account/Login.cshtml
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Hardcoded credentials for demonstration purposes
            if (model.Username == "admin" && model.Password == "password")
            {
                return RedirectToAction("SecondPage");
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
        }
        return View(model);
    }

    public IActionResult SecondPage()
    {
        var model = new SecondPageModel(); // Ensure the model exists
        return View("2nd", model); // Ensure the file exists: Views/Account/2nd.cshtml
    }

    public IActionResult Logout()
    {
        // Here you can clear session or authentication data if implemented
        return RedirectToAction("Login", "Account"); // Redirects to login page
    }
}
