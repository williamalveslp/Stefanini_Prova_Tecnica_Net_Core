using System.ComponentModel;

namespace StefaniniCore.Infra.CrossCutting.Configs.DataTransfers
{
    public class CorsSettings
    {
        [Description("Key is like a name for the Cors. Example: 'MY_CORS_KEY'.")]
        public string Key { get; set; }


        [Description("Urls allowed. Example: 'http://localhost:3000;http://localhost:3010'")]
        public string OriginUrlsAllowed { get; set; }
    }
}
