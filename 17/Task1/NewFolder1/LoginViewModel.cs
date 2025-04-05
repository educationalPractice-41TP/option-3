using System.ComponentModel;

namespace StudentDiary
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string _message;
        private User _loggedUser;

        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }

        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(nameof(Password)); }
        }

        public string Message
        {
            get => _message;
            set { _message = value; OnPropertyChanged(nameof(Message)); }
        }

        public User LoggedUser => _loggedUser;

        public bool Login()
        {
            var user = UserService.Authenticate(Username, Password);
            if (user != null)
            {
                _loggedUser = user;
                Message = $"Добро пожаловать, {user.Username}!";
                return true;
            }
            else
            {
                Message = "Неверный логин или пароль!";
                return false;
            }

        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
