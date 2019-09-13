﻿using DeliveryServer.Data;
using DeliveryServer.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DeliveryServer.Controllers
{
    [EnableCors("http://localhost:4200", "*", "*")]
    [RoutePrefix("auth")]
    public class AuthenticationController : ApiController
    {
        [Route("login")]
        [HttpPost]
        public IHttpActionResult Login([FromBody]User user)
        {
            return null;
        }

        [Route("register")]
        [HttpPost]
        public IHttpActionResult Register([FromBody]User user)
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    var exists = context.Users.Any(n => n.UserName == user.UserName);
                    if (exists) return BadRequest("User already exists");

                    context.Users.Add(user);
                    context.SaveChanges();

                    return Ok(CreateToken(user));
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return null;
        }

        private JwtPackage CreateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var claims = new ClaimsIdentity(new[] {
                new Claim(ClaimTypes.Email, user.Id.ToString())
            });

            const string secretKey = "your secret key goes here";
            var securityKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(secretKey));
            var signinCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = (JwtSecurityToken)tokenHandler.CreateJwtSecurityToken(
                    subject: claims,
                    signingCredentials: signinCredentials
                );

            var tokenString = tokenHandler.WriteToken(token);

            return new JwtPackage()
            {
                UserName = user.UserName,
                Id = user.Id,
                Token = tokenString
            };
        }


    }
}
public class JwtPackage
{
    public string Token { get; set; }
    public int Id { get; set; }
    public string UserName { get; set; }
}
