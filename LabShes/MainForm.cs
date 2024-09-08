using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabShes
{
    public partial class MainForm : Form
    {
        private List<Student> students = new List<Student>();
        private event EventHandler<StudentEventArgs> StudentAddedEvent;

        public MainForm()
        {
            InitializeComponent();
            StudentAddedEvent += MainForm_StudentAddedEvent;
            lstStudents.DisplayMember = "DisplayInfo"; // Указываем, что нужно отображать свойство DisplayInfo
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged; // Обработчик выбора студента
        }

        // Обработчик события добавления студента
        private void MainForm_StudentAddedEvent(object sender, StudentEventArgs e)
        {
            lblEventLog.Text += $"Добавлен студент: {e.Student.Name} {e.Student.Surname}\n";
        }

        // Добавление студента
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string surname = txtSurname.Text;
                DateTime dob = DateTime.Parse(txtDateOfBirth.Text);

                Student newStudent = new Student(name, surname, dob);
                students.Add(newStudent);

                // Событие добавления студента
                StudentAddedEvent?.Invoke(this, new StudentEventArgs { Student = newStudent });

                DisplayStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        // Добавление экзамена
        private void btnAddExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstStudents.SelectedItem is Student selectedStudent)
                {
                    string subject = txtSubject.Text;
                    int grade = int.Parse(txtGrade.Text);
                    DateTime examDate = DateTime.Parse(txtExamDate.Text);

                    Exam newExam = new Exam(subject, grade, examDate);
                    selectedStudent.AddExam(newExam);

                    DisplaySelectedStudentExams(selectedStudent); // Обновляем отображение экзаменов
                }
                else
                {
                    MessageBox.Show("Выберите студента из списка.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода: " + ex.Message);
            }
        }

        // Сохранение данных в файл
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Binary files (*.bin)|*.bin"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, students);
                    MessageBox.Show("Данные сохранены в файл.");
                }
            }
        }

        // Загрузка данных из файла
        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Binary files (*.bin)|*.bin"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    students = (List<Student>)formatter.Deserialize(fs);
                    DisplayStudents();
                    MessageBox.Show("Данные загружены из файла.");
                }
            }
        }

        // Отображение списка студентов
        private void DisplayStudents()
        {
            lstStudents.Items.Clear();
            foreach (var student in students)
            {
                lstStudents.Items.Add(student); // Добавляем студента в список
            }
        }

        // Обработчик выбора студента в списке
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem is Student selectedStudent)
            {
                DisplaySelectedStudentExams(selectedStudent); // Обновляем отображение экзаменов
            }
        }

        // Отображение экзаменов выбранного студента
        private void DisplaySelectedStudentExams(Student student)
        {
            lblExams.Text = ""; // Очищаем текст перед обновлением

            if (student.Exams.Count == 0)
            {
                lblExams.Text = "Экзамены отсутствуют";
                return;
            }

            foreach (var exam in student.Exams)
            {
                lblExams.Text += $"{exam.Subject}: Оценка {exam.Grade}, Дата: {exam.ExamDate.ToShortDateString()}\n";
            }
        }

        private void lstStudents_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblExams_Click(object sender, EventArgs e)
        {

        }
    }

    // Класс события для студента
    public class StudentEventArgs : EventArgs
    {
        public Student Student { get; set; }
    }
}