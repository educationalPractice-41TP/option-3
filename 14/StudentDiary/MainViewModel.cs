using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace StudentDiary
{
    public class MainViewModel : INotifyPropertyChanged
    {
        
        public ICommand FilterCommand { get; }
        public event PropertyChangedEventHandler? PropertyChanged;

        private DateTime? _filterDate;
        public DateTime? FilterDate
        {
            get => _filterDate;
            set
            {
                _filterDate = value;
                OnPropertyChanged();
                ApplyFilter();
            }
        }

        private ObservableCollection<Grade> _filteredGrades;
        public ObservableCollection<Grade> FilteredGrades
        {
            get => _filteredGrades;
            set
            {
                _filteredGrades = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Grade> Grades { get; set; }

        private Grade _selectedGrade;
        public Grade SelectedGrade
        {
            get => _selectedGrade;
            set
            {
                _selectedGrade = value;
                OnPropertyChanged();
                ((RelayCommand)EditGradeCommand).RaiseCanExecuteChanged();
                ((RelayCommand)DeleteGradeCommand).RaiseCanExecuteChanged();
            }
        }


        public ICommand AddGradeCommand { get; }
        public ICommand EditGradeCommand { get; }
        public ICommand DeleteGradeCommand { get; }
        public ICommand FilterGradesCommand { get; }

        public Schedule CurrentSchedule { get; set; } = new Schedule();

        public MainViewModel()
        {
            Grades = new ObservableCollection<Grade>();
            FilteredGrades = new ObservableCollection<Grade>(Grades); // Инициализация
            AddGradeCommand = new RelayCommand(AddGrade);
            EditGradeCommand = new RelayCommand(EditGrade, CanEditOrDelete);
            DeleteGradeCommand = new RelayCommand(DeleteGrade, CanEditOrDelete);
            FilterGradesCommand = new RelayCommand(param => ApplyFilter());
        }


        private void EditGrade(object? parameter)
        {
            if (SelectedGrade == null) return;
            var editWindow = new GradeEditWindow(SelectedGrade);
            if (editWindow.ShowDialog() == true)
            {
                OnPropertyChanged(nameof(Grades));
            }
        }

        private void AddGrade(object? parameter)
        {
            Console.WriteLine("Добавление оценки..."); // Проверка, вызывается ли метод
            var newGrade = new Grade { Subject = "Новый предмет", Date = DateTime.Today, Score = 5 };
            Grades.Add(newGrade);
            OnPropertyChanged(nameof(Grades)); // Уведомляем, что список изменился
        }

        private void ApplyFilter()
        {
            if (FilterDate == null)
            {
                FilteredGrades = new ObservableCollection<Grade>(Grades);
            }
            else
            {
                FilteredGrades = new ObservableCollection<Grade>(
                    Grades.Where(g => g.Date.Date == FilterDate.Value.Date));
            }
        }


        private void DeleteGrade(object? parameter)
        {
            if (SelectedGrade != null)
            {
                Grades.Remove(SelectedGrade);
                OnPropertyChanged(nameof(Grades)); // Уведомление об изменениях
            }
        }


        private bool CanEditOrDelete(object? parameter) => SelectedGrade != null;

        private void FilterGrades(object? parameter)
        {
            // Реализация фильтрации
        }

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}