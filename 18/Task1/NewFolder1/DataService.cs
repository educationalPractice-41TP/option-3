using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace StudentDiary
{

    public class AssignmentRecord
    {
        public string AssignmentName { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }

    public class ScheduleRecord
    {
        public string Subject { get; set; }
        public DateTime ClassTime { get; set; }
    }

    public class Diary
    {
        public List<GradeRecord> Grades { get; set; } = new List<GradeRecord>();
        public List<AssignmentRecord> Assignments { get; set; } = new List<AssignmentRecord>();
        public List<ScheduleRecord> Schedule { get; set; } = new List<ScheduleRecord>();
    }

    public class DataService
    {
        private const string DiaryFile = "diary.json";

        public static void SaveDiaryData(Diary diary)
        {
            string jsonData = JsonConvert.SerializeObject(diary, Formatting.Indented);
            File.WriteAllText(DiaryFile, jsonData);
        }

        public static Diary LoadDiaryData()
        {
            if (File.Exists(DiaryFile))
            {
                string jsonData = File.ReadAllText(DiaryFile);
                return JsonConvert.DeserializeObject<Diary>(jsonData);
            }
            return new Diary();
        }
    }
}
