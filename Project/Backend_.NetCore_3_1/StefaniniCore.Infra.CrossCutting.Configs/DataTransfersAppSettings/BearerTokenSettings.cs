using System.ComponentModel;

namespace StefaniniCore.Infra.CrossCutting.Configs.DataTransfers
{
    public class BearerTokenSettings
    {
        [Description("Your Secret key. Tip: Use a hash as Secret.")]
        public string Secret { get; set; }
    }
}
