using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    public class StudentModel
    {
        public string StudentName { get; set; }
        public List<GradeModel> Grades { get; set; } = new List<GradeModel>();
    }

}
