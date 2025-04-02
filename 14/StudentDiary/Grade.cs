using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    public class Grade
    {
        public string Subject { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}
