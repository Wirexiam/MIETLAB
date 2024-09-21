using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabShes
{
    [Serializable]
    public class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string surname;
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public DateTime DateOfBirth { get; set; }
        public List<Exam> Exams { get; set; } = new List<Exam>();

        public Student(string name, string surname, DateTime dob)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dob;
        }

        public void AddExam(Exam exam)
        {
            Exams.Add(exam);
            OnPropertyChanged(nameof(Exams));
        }

        public string DisplayInfo
        {
            get
            {
                string examsInfo = Exams.Count > 0 ? $"{Exams.Count} экзаменов" : "Экзамены отсутствуют";
                return $"{Name} {Surname} ({DateOfBirth.ToShortDateString()}), {examsInfo}";
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return DisplayInfo;
        }

        public override bool Equals(object obj)
        {
            if (obj is Student other)
                return Name == other.Name && Surname == other.Surname;
            return false;
        }

        public override int GetHashCode()
        {
            return (Name?.GetHashCode() ?? 0) ^ (Surname?.GetHashCode() ?? 0);
        }


        public IEnumerable<Exam> GetExamsAboveGrade(int grade)
        {
            foreach (var exam in Exams)
            {
                if (exam.Grade > grade)
                    yield return exam;
            }
        }

        public object DeepCopy()
        {
            return new Student(Name, Surname, DateOfBirth)
            {
                Exams = new List<Exam>(this.Exams)
            };
        }
    }
}
