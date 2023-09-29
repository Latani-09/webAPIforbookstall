using Azure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;
using webapi.Data;
using webapi.DTOs;
using webapi.Entities;
using webapi.Interface;
using webapi.Services;

namespace webapi.Controllers
{
    public class AccountController : BaseAPIController
    {
        private readonly DataContext _context;
        private readonly ITokenService _tokenService;

        public AccountController(DataContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }
        [HttpPost("register")]  //https://localhost:5001/api/register?username&password
        public async Task<ActionResult<UserDTO>> Result(RegisterDTO RegisterDTO)
        {
            if (await Userexist(RegisterDTO.username.ToLower()))
            {
                return BadRequest("username exist");
            }
            using var hmac = new HMACSHA512();  //dispose method then we have to use using keyword
            var user = new AppUser()
            {
                Name = RegisterDTO.username.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(RegisterDTO.password)),
                PasswordSalt = hmac.Key

            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return new UserDTO
            {
                Username = user.Name,
                token = _tokenService.createToken(user)
            };
        }
        [HttpPost("update")]  //https://localhost:5001/api/register?username&password
        public async Task<ActionResult<UserDTO>> update(RegisterDTO userin)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Name == userin.username);
            if (user==null)
            {
                return BadRequest("user does notexist");
            }
            using var hmac = new HMACSHA512();  //dispose method then we have to use using keyword
            user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(userin.password));
            user.PasswordSalt = hmac.Key;

            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return new UserDTO
            {
                Username = user.Name,
                token = _tokenService.createToken(user)
            };
        }
            private async Task<bool> Userexist(String username)
        {
            return await _context.Users.AnyAsync(x => x.Name == username);
        }
        [HttpPost("Login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO LoginDTO)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Name == LoginDTO.UserName);
            if (user == null)
            {
                return Unauthorized("invalid username");
            }
            using var hmac = new HMACSHA512(user.PasswordSalt);
            var computedhash = hmac.ComputeHash(Encoding.UTF8.GetBytes(LoginDTO.Password));
            for (int i = 0; i < computedhash.Length; i++)
            {
                if (user.PasswordHash[i] != computedhash[i])
                {
                    return Unauthorized("invalid password");
                }
            }
            return new UserDTO
            {
                Username = user.Name,
                token = _tokenService.createToken(user)
            };

        }
        [HttpDelete("delete/{Id}")]
        public async Task<ActionResult<UserDTO>> Delete(int Id)
        {
            var user = await _context.Users.SingleOrDefaultAsync(x => x.Id == Id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
                return Accepted("user deleted");
            }
            else { return BadRequest("username not exist"); }
        }
    }
}

