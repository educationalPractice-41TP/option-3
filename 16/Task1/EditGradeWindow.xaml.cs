using System;
using System.Windows;
using System.Linq;
using System.Windows.Controls;

namespace StudentDiary
{
    public partial class EditGradeWindow : Window
    {
        public GradeRecord EditedGrade { get; private set; }

        public EditGradeWindow(GradeRecord gradeToEdit)
        {
            InitializeComponent();

            string[] subjects = {
                "Математика",
                "Физика",
                "Программирование",
                "Английский язык",
                "История",
                "Физкультура"
            };

            subjectComboBox.ItemsSource = subjects;
            subjectComboBox.SelectedItem = gradeToEdit.Subject;
            gradeDatePicker.SelectedDate = gradeToEdit.Date;

 
            foreach (ComboBoxItem item in gradeComboBox.Items)
            {
                if (item.Content.ToString() == gradeToEdit.Grade.ToString())
                {
                    gradeComboBox.SelectedItem = item;
                    break;
                }
            }

            EditedGrade = new GradeRecord
            {
                Subject = gradeToEdit.Subject,
                Date = gradeToEdit.Date,
                Grade = gradeToEdit.Grade
            };
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (subjectComboBox.SelectedItem == null || gradeDatePicker.SelectedDate == null || gradeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            EditedGrade.Subject = subjectComboBox.SelectedItem.ToString();
            EditedGrade.Date = gradeDatePicker.SelectedDate.Value;
            EditedGrade.Grade = int.Parse((gradeComboBox.SelectedItem as ComboBoxItem).Content.ToString());

            DialogResult = true;
            Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}