using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabShes
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Exam> Exams { get; set; } = new List<Exam>();

        public Student(string name, string surname, DateTime dob)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dob;
        }

        // Добавление экзамена
        public void AddExam(Exam exam)
        {
            Exams.Add(exam);
        }

        // Свойство для отображения информации в списке
        public string DisplayInfo
        {
            get
            {
                string examsInfo = Exams.Count > 0 ? $"{Exams.Count} экзаменов" : "Экзамены отсутствуют";
                return $"{Name} {Surname} ({DateOfBirth.ToShortDateString()}), {examsInfo}";
            }
        }

        public override string ToString()
        {
            string examsInfo = Exams.Count > 0 ? string.Join("\n", Exams) : "Нет экзаменов";
            return $"{Name} {Surname}, Дата рождения: {DateOfBirth.ToShortDateString()}, Экзамены:\n{examsInfo}";
        }
    }
}
