namespace StefaniniCore.Application.ViewModels
{
    public class UserSystemDetailViewModel : ViewModelBase
    {
        public int Id { get; private set; }

        public string UserName { get; private set; }

        public string Password { get; private set; }

        private UserSystemDetailViewModel() : base() { }

        public void Load(int id, string userName, string password)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
        }
    }
}
