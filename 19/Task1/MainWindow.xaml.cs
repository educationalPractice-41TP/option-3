using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Threading;


namespace StudentDiary
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public static readonly RoutedUICommand EditGradeCommand = new RoutedUICommand(
            "Edit Grade",
            "EditGradeCommand",
            typeof(MainWindow),
            new InputGestureCollection { new KeyGesture(Key.E, ModifierKeys.Control) });

        public static readonly RoutedUICommand DeleteGradeCommand = new RoutedUICommand(
            "Delete Grade",
            "DeleteGradeCommand",
            typeof(MainWindow),
            new InputGestureCollection { new KeyGesture(Key.Delete) });

        private List<GradeRecord> gradeRecords = new List<GradeRecord>();
        private ObservableCollection<StudentGrade> studentGrades = new ObservableCollection<StudentGrade>();
        private double overallAverage;
        public event PropertyChangedEventHandler PropertyChanged;

        public User LoggedUser { get; }


        public double OverallAverage
        {
            get => overallAverage;
            set
            {
                overallAverage = value;
                OnPropertyChanged(nameof(OverallAverage));
            }
        }

        public MainWindow(User user)
        {
            InitializeComponent();
            LoggedUser = user;
            DataContext = new StudentViewModel();
            Loaded += async (s, e) => await ((StudentViewModel)DataContext).LoadStudentsAsync();

            LoadSubjects();
            LoadSampleData();
            UpdateSubjectsGrid();
            Loaded += (s, e) => scheduleGrid.Focus();

            studentGradesList.ItemsSource = studentGrades;
            studentGrades.CollectionChanged += (s, e) => CalculateOverallAverage();
            LoadSampleStudentData();

            if (LoggedUser.Role == UserRole.Student)
            {
                // Пример: отключаем кнопку редактирования и удаления.
                editGradeButton.IsEnabled = false;
                deleteGradeButton.IsEnabled = false;
                addGradeButton.IsEnabled = false;
        
            }
        }

        private void LoadSubjects()
        {
            string[] subjects = {
                "Математика",
                "Физика",
                "Программирование",
                "Английский язык",
                "История",
                "Физкультура"
            };

            subjectComboBox.ItemsSource = subjects;
            subjectComboBox.SelectedIndex = 0;
            gradeDatePicker.SelectedDate = DateTime.Now;
            gradeComboBox.SelectedIndex = 0;
        }

        private void LoadSampleData()
        {
            gradeRecords.Add(new GradeRecord { Subject = "Математика", Date = DateTime.Now.AddDays(-5), Grade = 5 });
            gradeRecords.Add(new GradeRecord { Subject = "Физика", Date = DateTime.Now.AddDays(-4), Grade = 4 });
            gradeRecords.Add(new GradeRecord { Subject = "Программирование", Date = DateTime.Now.AddDays(-3), Grade = 5 });
            gradeRecords.Add(new GradeRecord { Subject = "Английский язык", Date = DateTime.Now.AddDays(-2), Grade = 3 });
            gradeRecords.Add(new GradeRecord { Subject = "История", Date = DateTime.Now.AddDays(-1), Grade = 4 });

            scheduleGrid.ItemsSource = gradeRecords;
        }

        private void LoadSampleStudentData()
        {
            studentGrades.Add(new StudentGrade { StudentName = "Иванов Иван", Subject = "Математика", Grade = 4 });
            studentGrades.Add(new StudentGrade { StudentName = "Иванов Иван", Subject = "Физика", Grade = 5 });
            studentGrades.Add(new StudentGrade { StudentName = "Петров Петр", Subject = "Математика", Grade = 3 });
            studentGrades.Add(new StudentGrade { StudentName = "Петров Петр", Subject = "Программирование", Grade = 4 });

            CalculateOverallAverage();
        }

        private void AddGrade_Click(object sender, RoutedEventArgs e)
        {
            AddNewGrade();
        }

        private void AddGradeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            addGradeTab.IsSelected = true;
        }

        private void EditGradeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            var selectedGrade = scheduleGrid.SelectedItem as GradeRecord;
            if (selectedGrade == null)
            {
                MessageBox.Show("Выберите оценку для редактирования!");
                return;
            }

            var editWindow = new EditGradeWindow(selectedGrade);
            if (editWindow.ShowDialog() == true)
            {
                selectedGrade.Subject = editWindow.EditedGrade.Subject;
                selectedGrade.Date = editWindow.EditedGrade.Date;
                selectedGrade.Grade = editWindow.EditedGrade.Grade;

                scheduleGrid.Items.Refresh();
                RefreshDataGridsWithFade();
                UpdateSubjectsGrid();
            }
        }

        private void DeleteGradeCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            DeleteSelectedGrade();
        }

        private void ScheduleGrid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                DeleteSelectedGrade();
                e.Handled = true;
            }
        }

        private void DeleteSelectedGrade()
        {
            var selectedGrade = scheduleGrid.SelectedItem as GradeRecord;
            if (selectedGrade == null)
            {
                MessageBox.Show("Выберите оценку для удаления!");
                return;
            }

            var result = MessageBox.Show(
                $"Вы уверены, что хотите удалить оценку по предмету {selectedGrade.Subject}?",
                "Подтверждение удаления",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                gradeRecords.Remove(selectedGrade);
                RefreshDataGridsWithFade();

            }
        }

        private void AddNewGrade()
        {
            if (subjectComboBox.SelectedItem == null || gradeDatePicker.SelectedDate == null || gradeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            string subject = subjectComboBox.SelectedItem.ToString();
            DateTime date = gradeDatePicker.SelectedDate.Value;
            int grade = int.Parse((gradeComboBox.SelectedItem as ComboBoxItem).Content.ToString());

            var newGrade = new GradeRecord { Subject = subject, Date = date, Grade = grade };
            gradeRecords.Add(newGrade); // только один раз

            RefreshDataGridsWithFade();

            var lastItem = gradeRecords.Last();
            scheduleGrid.ScrollIntoView(lastItem);

            Dispatcher.BeginInvoke(new Action(() =>
            {
                scheduleGrid.UpdateLayout();

                var row = (DataGridRow)scheduleGrid.ItemContainerGenerator.ContainerFromItem(lastItem);
                if (row != null)
                {
                    row.Background = new SolidColorBrush(Colors.White); // важно: задать вручную

                    var sb = (Storyboard)this.Resources["HighlightRow"];
                    Storyboard.SetTarget(sb, row);
                    sb.Begin();
                }
            }), DispatcherPriority.Background);



            MessageBox.Show("Оценка добавлена!");

            subjectComboBox.SelectedIndex = 0;
            gradeDatePicker.SelectedDate = DateTime.Now;
            gradeComboBox.SelectedIndex = 0;
        }


        private void RefreshDataGrids()
        {
            scheduleGrid.ItemsSource = null;
            scheduleGrid.ItemsSource = gradeRecords;
            UpdateSubjectsGrid();
        }

        private void UpdateSubjectsGrid()
        {
            var subjectsSummary = gradeRecords
                .GroupBy(g => g.Subject)
                .Select(g => new SubjectSummary
                {
                    Name = g.Key,
                    AverageGrade = g.Average(gr => gr.Grade),
                    GradesCount = g.Count()
                })
                .ToList();

            subjectsGrid.ItemsSource = subjectsSummary;
        }

        private void ApplyFilter_Click(object sender, RoutedEventArgs e)
        {
            if (dateFilter.SelectedDate.HasValue)
            {
                var filtered = gradeRecords.Where(g => g.Date.Date == dateFilter.SelectedDate.Value.Date).ToList();
                scheduleGrid.ItemsSource = filtered;
            }
        }

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            var sb = (Storyboard)this.Resources["FadeInAnimation"];
            Storyboard.SetTarget(sb, MainGrid);
            sb.Begin();
        }

        private void ResetFilter_Click(object sender, RoutedEventArgs e)
        {
            dateFilter.SelectedDate = null;
            scheduleGrid.ItemsSource = gradeRecords;
        }

        private void ShowAllGrades_Click(object sender, RoutedEventArgs e)
        {
            scheduleGrid.ItemsSource = gradeRecords;
            dateFilter.SelectedDate = null;
        }


        private void RefreshDataGridsWithFade()
        {
            var fadeOut = (Storyboard)FindResource("FadeOut");
            var fadeIn = (Storyboard)FindResource("FadeIn");

            Storyboard.SetTarget(fadeOut, fadeContainer);
            Storyboard.SetTarget(fadeIn, fadeContainer);

            fadeOut.Completed += (s, e) =>
            {
                RefreshDataGrids(); // <-- твой метод обновления данных
                fadeIn.Begin();
            };

            fadeOut.Begin();
        }


        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new AddStudentWindow(vm =>
            {
                var newStudent = new StudentGrade
                {
                    StudentName = vm.StudentName,
                    Subject = vm.SelectedSubject,
                    Grade = vm.SelectedGrade
                };

                studentGrades.Add(newStudent);
  
                MessageBox.Show(
                    $"Студент {newStudent.StudentName} успешно добавлен!\n" +
                    $"Предмет: {newStudent.Subject}\n" +
                    $"Оценка: {newStudent.Grade}",
                    "Успешно",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            });

            dialog.ShowDialog();
        }

        private void UpdateGrades_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Оценки обновлены!", "Обновление", MessageBoxButton.OK, MessageBoxImage.Information);
        } 

        private void CalculateOverallAverage()
        {
            if (studentGrades.Any())
            {
                OverallAverage = studentGrades.Average(sg =>  sg.Grade);
            }
            else
            {
                OverallAverage = 0;
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {   
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class GradeRecord
    {
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public int Grade { get; set; }
    }

    public class SubjectSummary
    {
        public string Name { get; set; }
        public double AverageGrade { get; set; }
        public int GradesCount { get; set; }
    }

    public class StudentGrade : INotifyPropertyChanged
    {
        private string studentName;
        private string subject;
        private int grade;
        private double averageGrade;

        public string StudentName
        {
            get => studentName;
            set
            {
                studentName = value;
                OnPropertyChanged(nameof(StudentName));
            }
        }

        public string Subject
        {
            get => subject;
            set
            {
                subject = value;
                OnPropertyChanged(nameof(Subject));
            }
        }

        public int Grade
        {
            get => grade;
            set
            {
                grade = value;
                OnPropertyChanged(nameof(Grade));
                CalculateAverage();
            }
        }

        public double AverageGrade
        {
            get => averageGrade;
            set
            {
                averageGrade = value;
                OnPropertyChanged(nameof(AverageGrade));
            }
        }

        private void CalculateAverage()
        {
            AverageGrade = Grade;
        }   

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}