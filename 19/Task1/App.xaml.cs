using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StudentDiary
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // Если пользователей нет, создаём тестовых:
            if (UserService.LoadUsers().Count == 0)
            {
                UserService.RegisterUser("teacher1", "password1", UserRole.Teacher);
                UserService.RegisterUser("student1", "password1", UserRole.Student);
            }

        }
    }
}
