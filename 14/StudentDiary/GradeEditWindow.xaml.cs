using System.Windows;

namespace StudentDiary
{
    public partial class GradeEditWindow : Window
    {
        public Grade Grade { get; private set; }

        public GradeEditWindow(Grade grade)
        {
            InitializeComponent();
            Grade = grade;
            DataContext = Grade;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}