using System.Windows;

namespace StudentDiary
{
    public partial class GradeEditWindow : Window
    {
        public Grade Grade { get; } = new Grade(); // Инициализация по умолчанию

        public GradeEditWindow()
        {
            InitializeComponent();
            Grade.Date = DateTime.Today;
            DataContext = this;
        }

        public GradeEditWindow(Grade gradeToEdit) : this()
        {
            Grade.Subject = gradeToEdit.Subject;
            Grade.Date = gradeToEdit.Date;
            Grade.Score = gradeToEdit.Score;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Grade.Subject))
            {
                MessageBox.Show("Введите название предмета!");
                return;
            }

            if (Grade.Score < 1 || Grade.Score > 5)
            {
                MessageBox.Show("Оценка должна быть от 1 до 5!");
                return;
            }

            DialogResult = true;
            Close();
        }
    }
}