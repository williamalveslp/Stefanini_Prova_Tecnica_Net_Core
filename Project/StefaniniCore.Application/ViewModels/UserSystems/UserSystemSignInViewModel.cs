namespace StefaniniCore.Application.ViewModels
{
    public class UserSystemSignInViewModel : ViewModelBase
    {
        public string UserName { get; private set; }

        public string Password { get; private set; }

        public void Load(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
    }
}
