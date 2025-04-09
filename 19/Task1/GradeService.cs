using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;



    namespace StudentDiary
    {
        public class GradeService
        {
            public async Task<List<StudentModel>> GetStudentsAsync()
            {
                // Имитация асинхронной загрузки данных
                await Task.Delay(2000);  // Задержка для симуляции загрузки данных

                return new List<StudentModel>
            {
                new StudentModel
                {
                    StudentName = "Иванов Иван",
                    Grades = new List<GradeModel>
                    {
                        new GradeModel { Subject = "Математика", Grade = 4, Date = DateTime.Now },
                        new GradeModel { Subject = "Физика", Grade = 5, Date = DateTime.Now }
                    }
                },
                new StudentModel
                {
                    StudentName = "Петров Петр",
                    Grades = new List<GradeModel>
                    {
                        new GradeModel { Subject = "Программирование", Grade = 3, Date = DateTime.Now }
                    }
                }
            };
            }
        }
    }


