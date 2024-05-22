using BioDnaLab.Application.CommandQuery.Account.Dto.Account;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BioDnaLab.Api.Helper.Token
{
    public class GenerateToken
    {
        IConfiguration _config;
        public GenerateToken(IConfiguration configuration)
        {
            _config = configuration;
        }
        public string GenerateJSONWebToken(AccountDto user)
        {
            //create claims details based on the user information
            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _config["Jwt:Subject"]),
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("UserId", user.Id.ToString()),
                        new Claim("DisplayName", user.Name),
                        new Claim("UserName", user.Name),
                        new Claim("Email", user.Email)
                    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(10),
                signingCredentials: signIn);

            //return Ok(new JwtSecurityTokenHandler().WriteToken(token));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
