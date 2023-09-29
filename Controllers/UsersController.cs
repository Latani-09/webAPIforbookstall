using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Controllers;
using webapi.Data;
using webapi.Entities;

namespace udemi_Datingapp.API.Controllers
{

    public class UsersController : BaseAPIController
    {
        private readonly DataContext _context; //private field

        public UsersController(DataContext context)
        {
            _context = context;  //_context
        }
        [HttpGet] ///create endpoit
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> Getuser()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
        [Authorize]
        [HttpGet("{Id}")] ///create endpoit
        public async Task<ActionResult<AppUser>> Getuser(int Id)
        {
            return await _context.Users.FindAsync(Id);
        }
    }
}
