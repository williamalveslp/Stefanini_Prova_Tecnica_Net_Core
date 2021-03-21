using Microsoft.IdentityModel.Tokens;
using StefaniniCore.Infra.CrossCutting.Configs.TokenBearerJwt.Models;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StefaniniCore.Infra.CrossCutting.Configs.TokenBearerJwt
{
    public static class TokenBearerJwtConfig
    {
        /// <summary>
        /// Generate the Token as Bearer JWT.
        /// </summary>
        /// <param name="userJwt"></param>
        /// <returns></returns>
        public static string GenerateToken(UserJwt userJwt)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(SecretConfig.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, userJwt.Username.ToString()),
                    new Claim(ClaimTypes.Role, userJwt.Role.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
