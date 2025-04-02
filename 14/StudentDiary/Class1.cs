using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    public class LessonSlot
    {
        public int Number { get; set; }
        public string Subject { get; set; } = string.Empty;
    }

    public class Schedule
    {
        public ObservableCollection<LessonSlot> MondaySchedule { get; } = new();
        public ObservableCollection<LessonSlot> TuesdaySchedule { get; } = new();
        public ObservableCollection<LessonSlot> WednesdaySchedule { get; } = new();
        public ObservableCollection<LessonSlot> ThursdaySchedule { get; } = new();
        public ObservableCollection<LessonSlot> FridaySchedule { get; } = new();
        public ObservableCollection<LessonSlot> SaturdaySchedule { get; } = new();

        public Schedule()
        {
            InitializeDay(MondaySchedule, "Математика", "Физика", "Химия", "Литература");
            InitializeDay(TuesdaySchedule, "История", "Английский", "Биология", "Физкультура");
            InitializeDay(WednesdaySchedule, "География", "Информатика", "Искусство");
            InitializeDay(ThursdaySchedule, "Экономика", "Право", "Астрономия");
            InitializeDay(FridaySchedule, "Музыка", "Технологии", "ОБЖ");
            InitializeDay(SaturdaySchedule, "Проектная работа", "Экология");
        }

        private void InitializeDay(ObservableCollection<LessonSlot> day, params string[] subjects)
        {
            for (int i = 0; i < 8; i++)
            {
                day.Add(new LessonSlot
                {
                    Number = i + 1,
                    Subject = i < subjects.Length ? subjects[i] : "Окно"
                });
            }
        }
    }
}
