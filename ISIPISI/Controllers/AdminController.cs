using ISIPISI.Models;
using ISIPISI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISIPISI.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<IdentityUser> _userManager;
        private AppDbContext _context;

        public AdminController(AppDbContext appDbContext,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _context = appDbContext;
        }

        public IActionResult Members()
        {
            var mvm = new MembersViewModel();
            var entryPoint = from users in _context.Users
                              join userRole in _context.UserRoles on users.Id equals userRole.UserId
                              join roles in _context.Roles on userRole.RoleId equals roles.Id
                              select new
                              {
                                  username = users.UserName,
                                  role = roles.Name
                              };

            foreach(var a in entryPoint)
            {
                mvm.users.Add(new UserViewModel
                {
                    username = a.username,
                    currentRole = a.role
                });
            }
            return View(mvm);
        }

        [Route("/Admin/Demote/{username}")]
        public async Task<IActionResult> Demote(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if(await _userManager.IsInRoleAsync(user, "Volunteer"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Volunteer");
                await _userManager.AddToRoleAsync(user, "Guest");

            } else if (await _userManager.IsInRoleAsync(user, "Admin"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Admin");
                await _userManager.AddToRoleAsync(user, "Volunteer");
            }

            return RedirectToAction("Members", "Admin");
        }

        [Route("/Admin/Promote/{username}")]
        public async Task<IActionResult> Promote(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (await _userManager.IsInRoleAsync(user, "Volunteer"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Volunteer");
                await _userManager.AddToRoleAsync(user, "Admin");

            }
            else if (await _userManager.IsInRoleAsync(user, "Guest"))
            {
                await _userManager.RemoveFromRoleAsync(user, "Guest");
                await _userManager.AddToRoleAsync(user, "Volunteer");
            }

            return RedirectToAction("Members", "Admin");
        }

        [Route("/Admin/Approve/{reportId}")]
        public IActionResult Approve(int reportId)
        {
            _context.Reports.FirstOrDefault(r => r.EventReportId == reportId).Approved = true;
            _context.SaveChanges();

            return RedirectToAction("Modify", "Map");
        }
    }
}
