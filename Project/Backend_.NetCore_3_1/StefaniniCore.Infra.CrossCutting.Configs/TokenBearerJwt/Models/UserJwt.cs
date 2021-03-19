namespace StefaniniCore.Infra.CrossCutting.Configs.TokenBearerJwt.Models
{
    public class UserJwt
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
