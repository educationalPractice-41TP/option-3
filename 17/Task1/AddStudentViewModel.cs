using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace StudentDiary
{
    public class AddStudentViewModel
    {
        public string StudentName { get; set; }
        public List<string> Subjects { get; } = new List<string>
        {
            "Математика",
            "Физика",
            "Программирование",
            "Английский язык",
            "История",
            "Физкультура"
        };

        public List<int> Grades { get; } = new List<int> { 5, 4, 3, 2, 1 };

        public string SelectedSubject { get; set; }
        public int SelectedGrade { get; set; }

        public ICommand AddCommand { get; }

        public AddStudentViewModel(Action<AddStudentViewModel> addAction)
        {
            AddCommand = new RelayCommand(_ =>
            {
                if (string.IsNullOrWhiteSpace(StudentName))
                {
                    MessageBox.Show("Введите имя студента!", "Ошибка",
                                  MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                addAction(this);
            });
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action<object> _execute;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action<object> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter) => true;
        public void Execute(object parameter) => _execute(parameter);
    }
}