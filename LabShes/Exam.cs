using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabShes
{
    [Serializable]
    public class Exam
    {
        public string Subject { get; set; }
        public int Grade { get; set; }
        public DateTime ExamDate { get; set; }

        public Exam(string subject, int grade, DateTime examDate)
        {
            Subject = subject;
            Grade = grade;
            ExamDate = examDate;
        }

        public override string ToString()
        {
            return $"{Subject}: Оценка {Grade}, Дата: {ExamDate.ToShortDateString()}";
        }
    }
}
