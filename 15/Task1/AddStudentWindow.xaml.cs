using System;
using System.Windows;

namespace StudentDiary
{
    public partial class AddStudentWindow : Window
    {
        public AddStudentWindow(Action<AddStudentViewModel> addAction)
        {
            InitializeComponent();
            DataContext = new AddStudentViewModel(addAction);

            // Установка начальных значений
            if (DataContext is AddStudentViewModel vm)
            {
                vm.SelectedSubject = vm.Subjects[0];
                vm.SelectedGrade = vm.Grades[0];
            }

            // Фокус на поле ввода имени при открытии окна
            Loaded += (s, e) => studentNameTextBox.Focus();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}