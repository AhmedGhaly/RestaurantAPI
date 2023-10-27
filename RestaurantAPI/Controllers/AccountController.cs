﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RestaurantAPI.Dto;
using RestaurantAPI.Interfaces;
using RestaurantAPI.Models;
using RestaurantAPI.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RestaurantAPI.Controllers
{
	
	public class AccountController :BaseApiClass
	{
		private readonly UserManager<ApplicationIdentityUser> userManager;
		private readonly IConfiguration config;
        private readonly IToken token;
        private readonly IUserRepository userRepository;

        public AccountController(
            UserManager<ApplicationIdentityUser> _userManager,
            IConfiguration config, 
            IToken token,
            IUserRepository userRepository)
        {
			userManager = _userManager;
			this.config = config;
            this.token = token;
            this.userRepository = userRepository;
        }
        [HttpPost("register")]
		public async Task<IActionResult> Register(RegisterDto userDto)
		{
            if ( !ModelState.IsValid )
                return BadRequest(ModelState);
            bool emailExists = await CheckIfEmailExists(userDto.Email);
            if (emailExists)
                return BadRequest("Email already exists");


            ApplicationIdentityUser user = new ApplicationIdentityUser()
			{
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
				Address = userDto.Address,
				UserName = userDto.Email.Split('@')[0],
				PhoneNumber = userDto.Phone,
				CreatedAt = DateTime.UtcNow
			};
			var result =await userManager.CreateAsync(user,userDto.Password);
			if (!result.Succeeded)
				return BadRequest(result.Errors.FirstOrDefault());

            User myUser = new User()
            {
                application_user_id = user.Id,
            };
            userRepository.add(myUser);
            userRepository.SaveChanges();
            return Ok("Account created successfuly");
				
        }
		[HttpPost("LogIn")]
		public async Task<ActionResult<UserDTOResult>> LogIn(LogInDto userDto)
		{
			if (!ModelState.IsValid)
				return BadRequest();
            var user = await userManager.FindByEmailAsync(userDto.Email);
			if (user == null)
				return Unauthorized();
				
			var Succeeded = await userManager.CheckPasswordAsync(user, userDto.Password);

			if (!Succeeded)
                return Unauthorized();

			List<Claim> claims = await GetClaims(user);
            JwtSecurityToken Mytoken = token.generateToken(claims);
          
            return Ok(new UserDTOResult()
            {
                token = new JwtSecurityTokenHandler().WriteToken(Mytoken),
                expiration = Mytoken.ValidTo
            });				      
		}
        


		private async Task<List<Claim>> GetClaims(ApplicationIdentityUser user)
        {
            var claims = new List<Claim>()
                        {
                            new Claim(ClaimTypes.Name,user.UserName),
                            new Claim(ClaimTypes.NameIdentifier,user.Id),
                            new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
                        };
            var roles = await userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

			return claims;
        }
        private async Task<bool> CheckIfEmailExists(string email)
        {
            var existingUser = await userManager.FindByEmailAsync(email);
            return (existingUser != null);
        }
        private string GetUserIdFromClaims()
        {
            var Identifier = User.FindFirst(ClaimTypes.NameIdentifier);
            var UserId = Identifier.Value;
            return UserId;
        }
        [HttpGet]
        [Authorize]
        public ActionResult test()
        {
            return Ok(GetUserIdFromClaims());
        }
    }
}
