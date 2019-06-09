using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using UniLoginBack.Models;
using UniLoginBack.Models.DTO;

namespace UniLoginBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UNIDB001Context db;

        public LoginController(UNIDB001Context context)
        {
            db = context;
        }

        // POST: api/Login
        [HttpPost]
        public async Task<IActionResult> PostUnitb001Usuario(LoginDTO loginDTO)
        {
            Unitb001Usuario u = db.Unitb001Usuario.Where(x => x.EdEmail == loginDTO.edEmail).FirstOrDefault();
            if (u == null)
            {
                return StatusCode(401);
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("id", u.CoPessoa.ToString()),
                    new Claim("name", u.NoUsuario.ToString()),
                    new Claim("email", u.EdEmail.ToString()),
                    new Claim("clientId", loginDTO.client)
                }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);


            return CreatedAtAction("", new TokenDTO
            {
                AccessToken = tokenHandler.WriteToken(token)
            });
        }

       
    }
}