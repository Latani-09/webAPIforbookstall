﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Primitives;
using System.Security.Claims;
using System.Security.Cryptography;
using webapi.DTOs;
using webapi.Entities;
using webapi.Interface;

namespace webapi.Controllers
{
    public class AccountController : BaseAPIController
    {
        private readonly ITokenService _tokenService;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AccountController(UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager, ITokenService tokenService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _tokenService = tokenService;

        }

        [HttpPost("register")]  //https://localhost:5001/api/register?username&password
        public async Task<ActionResult<UserDTO>> Result(RegisterDTO RegisterDTO)
        {
            if (await Userexist(RegisterDTO.username.ToLower()))
            {
                return BadRequest("username exist");
            }

            var user = new AppUser()
            {
                UserName = RegisterDTO.username.ToLower(),
            };
            var result = await _userManager.CreateAsync(user, RegisterDTO.password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            var roleResult = await _userManager.AddToRoleAsync(user, "Member");

            if (!roleResult.Succeeded) return BadRequest(result.Errors);
            return new UserDTO
            {
                Username = user.UserName,
                token = await _tokenService.createToken(user)
            };
        }


        [Authorize(Roles = "moderator")]
        [HttpPost("update")]  //https://localhost:5001/api/register?username&password
        public async Task<ActionResult<UserDTO>> update(RegisterDTO userin)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(x => x.UserName == userin.username);
            if (user == null)
            {
                return BadRequest("user does notexist");
            }
            using var hmac = new HMACSHA512();  //dispose method then we have to use using keyword
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
    
            Console.WriteLine("logged in user-----------------------------", userId);
 
            return new UserDTO
            {
                Username = user.UserName,
                token = await _tokenService.createToken(user)
            };
        }
        private async Task<bool> Userexist(String username)
        {
            return await _userManager.Users.AnyAsync(x => x.UserName == username);
        }



        [HttpPost("Login")]
        public async Task<ActionResult<UserDTO>> Login(LoginDTO LoginDTO)
        {
            var user = await _userManager.Users

               .SingleOrDefaultAsync(x => x.UserName == LoginDTO.UserName.ToLower());

            if (user == null) return Unauthorized("Invalid username");

            var result = await _signInManager

                .CheckPasswordSignInAsync(user, LoginDTO.Password, false);
            if (!result.Succeeded) return Unauthorized();
            

            return new UserDTO
            {
                Id=user.Id,
                Username = user.UserName,
                token = await _tokenService.createToken(user),
            };
        }
        [HttpPost("Logout")]
        public async Task<ActionResult> Logout( )
        {

            await _signInManager.SignOutAsync();

            return Ok("logged out");

        }


        [Authorize(Roles = "Admin")]
        [HttpDelete("delete/{Id}")]
        public async Task<ActionResult<UserDTO>> Delete(int Id)
        {
            var user = await _userManager.Users.SingleOrDefaultAsync(x => x.Id == Id);
            if (user != null)
            {

                await _userManager.DeleteAsync(user);
                return Accepted("user deleted");
            }
            else { return BadRequest("username not exist"); }
        }
    }
}

