using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApplication1.Helper
{
    public class JwtHelper
    {
        public static string GenerateJsonWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenParameter.Secret));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claimsIdentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid, "213"));
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Name, "admin"));
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
            var token = new JwtSecurityToken(TokenParameter.Issuer,
              TokenParameter.Audience,
              claimsIdentity.Claims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
