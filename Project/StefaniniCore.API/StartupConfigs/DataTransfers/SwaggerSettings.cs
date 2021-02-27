using System.ComponentModel;

namespace StefaniniCore.API.StartupConfigs.DataTransfers
{
    internal class SwaggerSettings
    {
        public AppBuilderDto AppBuilder { get; set; }
        public ServiceCollectionDto ServiceCollection { get; set; }

        public class ServiceCollectionDto
        {
            public string Title { get; set; }

            [Description("API version to Swagger. Example: 'v1'")]
            public string Version { get; set; }

            public string Description { get; set; }

            public ContactDto Contact { get; set; }

            internal class ContactDto
            {
                public string Name { get; set; }
                public string Email { get; set; }
                public string Url { get; set; }
            }
        }

        public class AppBuilderDto
        {
            [Description("Url for Swagger. Example: '/api/swagger/{0}/swagger.json', the position is the Version.")]
            public string UrlSwagger { get; set; }
        }
    }
}
