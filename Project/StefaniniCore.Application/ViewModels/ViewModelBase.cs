namespace StefaniniCore.Application.ViewModels
{
    public abstract class ViewModelBase
    {
        public bool Success { get; set; }

        private string _messageError;

        public string MessageError
        {
            get { return this._messageError; }
            set
            {
                Success = false;
                this._messageError = value;
            }
        }

        public string StackTrace { get; set; }

        public ViewModelBase()
        {
            this.Success = true;
        }
    }
}
