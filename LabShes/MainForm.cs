using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace LabShes
{
    public partial class MainForm : MaterialForm
    {
        private MaterialSkinManager skinManager;
        private List<Student> students = new List<Student>();
        private event EventHandler<StudentEventArgs> StudentAddedEvent;

        public MainForm()
        {
            InitializeComponent();

            // Настройка MaterialSkin
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK; // Или MaterialSkinManager.Themes.DARK
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700, Primary.Blue200,
                Accent.LightBlue200, TextShade.WHITE);

            // Настройка событий
            StudentAddedEvent += MainForm_StudentAddedEvent;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lstStudents.DisplayMember = null; // ListBox будет отображать свойство DisplayInfo
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
                string name = txtName.Text.Trim();
                string surname = txtSurname.Text.Trim();
                DateTime dob;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
                {
                    MessageBox.Show("Имя и фамилия не могут быть пустыми.");
                    return;
                }

                if (!DateTime.TryParse(txtDateOfBirth.Text, out dob))
                {
                    MessageBox.Show("Неверный формат даты.");
                    return;
                }

                Student newStudent = new Student(name, surname, dob);
                students.Add(newStudent);

                // Добавление в список студентов
                lstStudents.Items.Add(newStudent);

                // Обработка события добавления студента
                StudentAddedEvent?.Invoke(this, new StudentEventArgs { Student = newStudent });

                ClearStudentInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }


        private void ClearStudentInputFields()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtDateOfBirth.Text = string.Empty;
        }



        // Добавление экзамена
        private void btnAddExam_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверяем, что выбран студент
                if (lstStudents.SelectedItem is Student selectedStudent)
                {
                    string subject = txtSubject.Text.Trim();
                    int grade;
                    DateTime examDate;

                    if (string.IsNullOrWhiteSpace(subject))
                    {
                        MessageBox.Show("Предмет не может быть пустым.");
                        return;
                    }

                    if (!int.TryParse(txtGrade.Text, out grade) || grade < 1 || grade > 5)
                    {
                        MessageBox.Show("Оценка должна быть числом от 1 до 5.");
                        return;
                    }

                    if (!DateTime.TryParse(txtExamDate.Text, out examDate))
                    {
                        MessageBox.Show("Неверный формат даты экзамена.");
                        return;
                    }

                    // Добавляем экзамен к выбранному студенту
                    Exam newExam = new Exam(subject, grade, examDate);
                    selectedStudent.AddExam(newExam);

                    // Обновляем отображение экзаменов для выбранного студента
                    DisplaySelectedStudentExams(selectedStudent);
                    ClearExamInputFields();
                }
                else
                {
                    MessageBox.Show("Выберите студента из списка.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }



        private void ClearExamInputFields()
        {
            txtSubject.Text = string.Empty;
            txtGrade.Text = string.Empty;
            txtExamDate.Text = string.Empty;
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
                try
                {
                    using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(fs, students);
                        MessageBox.Show("Данные сохранены в файл.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении: " + ex.Message);
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
                try
                {
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        students = (List<Student>)formatter.Deserialize(fs);

                        // Обновляем список студентов на форме
                        lstStudents.Items.Clear();
                        foreach (var student in students)
                        {
                            lstStudents.Items.Add(student);
                        }

                        // Если есть студенты, выбираем первого и отображаем его экзамены
                        if (students.Count > 0)
                        {
                            lstStudents.SelectedIndex = 0; // Выбираем первого студента
                            DisplaySelectedStudentExams(students[0]); // Отображаем его экзамены
                        }

                        MessageBox.Show("Данные загружены из файла.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при загрузке: " + ex.Message);
                }
            }
        }




        // Отображение списка студентов
        private void DisplayStudents()
        {
            lstStudents.Items.Clear();
            foreach (var student in students)
            {
                lstStudents.Items.Add(student); // Добавляем объект Student, а не строку DisplayInfo
            }
        }


        // Обработчик выбора студента в списке
        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem is Student selectedStudent)
            {
                DisplaySelectedStudentExams(selectedStudent);
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
        private void chkToggleTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (chkToggleTheme.Checked)
            {
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
                chkToggleTheme.Text = "Тёмная тема";
            }
            else
            {
                skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                chkToggleTheme.Text = "Светлая тема";
            }
        }

    }

    // Класс события для студента
    public class StudentEventArgs : EventArgs
    {
        public Student Student { get; set; }
    }
}