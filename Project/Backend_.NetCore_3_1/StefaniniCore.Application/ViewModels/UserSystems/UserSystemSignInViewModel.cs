namespace StefaniniCore.Application.ViewModels
{
    public class UserSystemSignInViewModel : ViewModelBase
    {
        public virtual string UserName { get; private set; }

        public virtual string Password { get; private set; }

        public void Load(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }
    }
}
