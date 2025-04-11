using System.Windows;

namespace StudentDiary
{
    public partial class LoginWindow : Window
    {
        public LoginViewModel ViewModel { get; }

        public LoginWindow()
        {
            InitializeComponent();
            ViewModel = new LoginViewModel();
            DataContext = ViewModel;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            // Передаём введённый пароль
            ViewModel.Password = passwordBox.Password;
            if (ViewModel.Login())
            {
                // Открываем главное окно в зависимости от роли
                MainWindow mainWin = new MainWindow(ViewModel.LoggedUser);
                mainWin.Show();
                this.Close();
            }
        }
    }
}
