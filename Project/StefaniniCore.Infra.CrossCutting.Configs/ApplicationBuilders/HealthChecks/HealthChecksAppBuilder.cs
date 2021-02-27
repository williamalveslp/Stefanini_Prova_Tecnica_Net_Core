using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading.Tasks;
using StefaniniCore.Infra.CrossCutting.Configs.DataTransfers;

namespace StefaniniCore.Infra.CrossCutting.Configs.ApplicationBuilders
{
    public static class HealthChecksAppBuilder
    {
        public static void UseHealthChecks(this IApplicationBuilder app, IConfiguration configuration)
        {
            var healthChecksData = ConfigurationTransfer.GetObject<HeathChecksSettings>(configuration);

            string pathString = healthChecksData?.AppBuilder?.PathString;
            string pathStringUI = healthChecksData?.AppBuilder?.PathStringUI;

            app.UseHealthChecks(pathString, new HealthCheckOptions()
            {
                Predicate = _ => true,
                ResponseWriter = WriteResponse
                //ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
            });

            if (!string.IsNullOrEmpty(pathStringUI))
            {
                app.UseHealthChecksUI(options =>
                {
                    options.UIPath = pathStringUI;
                });
            }
        }

        /// <summary>
        /// Response from Health Checks.
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        private static Task WriteResponse(HttpContext httpContext, HealthReport result)
        {
            httpContext.Response.ContentType = "application/json";
            var json = new JObject(
                new JProperty("status", result.Status.ToString()),
                new JProperty("results", new JObject(result.Entries.Select(pair =>
                new JProperty(pair.Key, new JObject(
                new JProperty("status", pair.Value.Status.ToString()),
                new JProperty("description", pair.Value.Description),
                new JProperty("data", new JObject(pair.Value.Data.Select(p => new JProperty(p.Key, p.Value))))))))));
            return httpContext.Response.WriteAsync(json.ToString(Formatting.Indented));
        }
    }
}