using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using StefaniniCore.Infra.CrossCutting.Configs.DataTransfers;
using StefaniniCore.Infra.CrossCutting.Configs.TokenBearerJwt.Models;
using System.Text;

namespace StefaniniCore.Infra.CrossCutting.Configs.StartupConfigs.ServicesCollection.AuthenticationBearerJwt
{
    public static class AuthenticationBearerJwtCollection
    {
        /// <summary>
        /// Add the Authentication and Authorization with Bearer JWT Token.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void AddAuthenticationJwt(this IServiceCollection services, IConfiguration configuration)
        {
            var bearerTokenSettings = ConfigurationTransfer.GetObject<BearerTokenSettings>(configuration);           
            string secret = bearerTokenSettings.Secret;

            byte[] key = Encoding.ASCII.GetBytes(secret);

            // Authentication.
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            // Authorization.
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            // Set the secret on static class.
            SecretConfig.Secret = secret;
        }
    }
}