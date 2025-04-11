using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Threading.Tasks;
using System.ComponentModel;
using global::StudentDiary;




    namespace StudentDiary
    {
        public class StudentViewModel : INotifyPropertyChanged
        {
            private readonly GradeService _gradeService;
            private bool _isLoading;
            private ObservableCollection<StudentModel> _students;

            public ObservableCollection<StudentModel> Students
            {
                get => _students;
                set
                {
                    _students = value;
                    OnPropertyChanged(nameof(Students));
                }       
            }

            public bool IsLoading
            {
                get => _isLoading;
                set
                {
                    _isLoading = value;
                    OnPropertyChanged(nameof(IsLoading));
                }
            }

            public ICommand AddGradeCommand { get; }

            public StudentViewModel()
            {
                _gradeService = new GradeService();
                AddGradeCommand = new RelayCommand(AddGrade);
            }

            public async Task LoadStudentsAsync()
            {
                IsLoading = true;
                Students = new ObservableCollection<StudentModel>(await _gradeService.GetStudentsAsync());
                IsLoading = false;
            }

            private void AddGrade(object parameter)
            {
                // Логика для добавления оценки
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }


        }
    }


