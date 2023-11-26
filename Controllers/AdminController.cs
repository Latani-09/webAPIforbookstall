using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using webapi.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;

namespace webapi.Controllers
{
    public class AdminController : BaseAPIController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public AdminController(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager) {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [Authorize (Roles ="Admin")]
        [HttpGet("get-user-with-roles")]
        public async Task<ActionResult> GetUserWithRoles()
        {
            Console.WriteLine("admin authorized content");
            var users =await _userManager.Users.OrderBy(u => u.UserName).Select(u => new
            {
                 u.Id,
                userName = u.UserName
            , Roles = u.UserRoles.Select(r => r.Role.Name).ToList()
            }).ToListAsync();
            return Ok(users);
        }
        [Authorize(Roles = "Admin")]
        [HttpPut("edit-user-roles/{username}")]
        public async Task<ActionResult> editUserRole(string username,[FromQuery]string role)
        {
            var user= await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                return NotFound("username invalid");
            }
            if (string.IsNullOrEmpty(role)) { return BadRequest("Atleast include one role Name in the Query"); }
            var selectedrole = role.Split(",").ToArray();
            var userroles = await  _userManager.GetRolesAsync(user);
            var result = await _userManager.AddToRolesAsync(user, selectedrole.Except(userroles));
            if (!result.Succeeded) { return BadRequest("cannot add roles"); }
            result=await _userManager.RemoveFromRolesAsync(user,userroles.Except(selectedrole));
            return Ok(_userManager.GetRolesAsync(user));
        }
    }
}
