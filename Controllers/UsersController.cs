using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Controllers;
using webapi.Entities;

namespace udemi_Datingapp.API.Controllers
{

    public class UsersController : BaseAPIController
    {
        private readonly UserManager<AppUser> _userManager;

        public UsersController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize (Roles ="Admin")]
        [HttpGet] ///create endpoit
        
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAllusers()
        {
            var users = await _userManager.Users.ToListAsync();
            
            return users;
        }
        [Authorize]
        [HttpGet("{Id}")] ///create endpoit
        public async Task<ActionResult<AppUser>> Getuser(int Id)
        {
            return await _userManager.FindByIdAsync(Id.ToString());
        }
    }
}
