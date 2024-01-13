using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAppDay10.DTOs;

namespace WebAppDay_8.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RoleStore roleStore)
        {
            var alreadyAdded = await _roleManager.RoleExistsAsync(roleStore.RoleName);

            if (!alreadyAdded)
            {
                await _roleManager.CreateAsync(new IdentityRole(roleStore.RoleName));
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
