namespace LabShes
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblName = new MaterialSkin.Controls.MaterialLabel();
            this.lblSurname = new MaterialSkin.Controls.MaterialLabel();
            this.lblDateOfBirth = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDateOfBirth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddStudent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblSubject = new MaterialSkin.Controls.MaterialLabel();
            this.lblGrade = new MaterialSkin.Controls.MaterialLabel();
            this.lblExamDate = new MaterialSkin.Controls.MaterialLabel();
            this.txtSubject = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtGrade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtExamDate = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnAddExam = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.lblExams = new MaterialSkin.Controls.MaterialLabel();
            this.btnSaveToFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnLoadFromFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblEventLog = new MaterialSkin.Controls.MaterialLabel();
            this.chkToggleTheme = new MaterialSkin.Controls.MaterialCheckBox();

            // Form settings
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Text = "Управление студентами и экзаменами";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // Label for Name
            this.lblName.Text = "Имя:";
            this.lblName.Location = new System.Drawing.Point(30, 80);
            this.lblName.AutoSize = true;

            // Text field for Name
            this.txtName.Hint = "Введите имя";
            this.txtName.Location = new System.Drawing.Point(150, 80);
            this.txtName.Width = 200;

            // Label for Surname
            this.lblSurname.Text = "Фамилия:";
            this.lblSurname.Location = new System.Drawing.Point(30, 120);
            this.lblSurname.AutoSize = true;

            // Text field for Surname
            this.txtSurname.Hint = "Введите фамилию";
            this.txtSurname.Location = new System.Drawing.Point(150, 120);
            this.txtSurname.Width = 200;

            // Label for Date of Birth
            this.lblDateOfBirth.Text = "Дата рождения:";
            this.lblDateOfBirth.Location = new System.Drawing.Point(30, 160);
            this.lblDateOfBirth.AutoSize = true;

            // Text field for Date of Birth
            this.txtDateOfBirth.Hint = "Введите дату рождения";
            this.txtDateOfBirth.Location = new System.Drawing.Point(150, 160);
            this.txtDateOfBirth.Width = 200;

            // Button to Add Student
            this.btnAddStudent.Text = "Добавить студента";
            this.btnAddStudent.Location = new System.Drawing.Point(30, 200);
            this.btnAddStudent.Width = 320;

            // Label for Subject
            this.lblSubject.Text = "Предмет:";
            this.lblSubject.Location = new System.Drawing.Point(30, 250);
            this.lblSubject.AutoSize = true;

            // Text field for Subject
            this.txtSubject.Hint = "Введите предмет";
            this.txtSubject.Location = new System.Drawing.Point(150, 250);
            this.txtSubject.Width = 200;

            // Label for Grade
            this.lblGrade.Text = "Оценка:";
            this.lblGrade.Location = new System.Drawing.Point(30, 290);
            this.lblGrade.AutoSize = true;

            // Text field for Grade
            this.txtGrade.Hint = "Введите оценку";
            this.txtGrade.Location = new System.Drawing.Point(150, 290);
            this.txtGrade.Width = 200;

            // Label for Exam Date
            this.lblExamDate.Text = "Дата экзамена:";
            this.lblExamDate.Location = new System.Drawing.Point(30, 330);
            this.lblExamDate.AutoSize = true;

            // Text field for Exam Date
            this.txtExamDate.Hint = "Введите дату экзамена";
            this.txtExamDate.Location = new System.Drawing.Point(150, 330);
            this.txtExamDate.Width = 200;

            // Button to Add Exam
            this.btnAddExam.Text = "Добавить экзамен";
            this.btnAddExam.Location = new System.Drawing.Point(30, 370);
            this.btnAddExam.Width = 320;

            // ListBox for displaying students
            this.lstStudents.Location = new System.Drawing.Point(400, 80);
            this.lstStudents.Size = new System.Drawing.Size(350, 150);

            // Label for displaying exams
            this.lblExams.Text = "Экзамены:";
            this.lblExams.Location = new System.Drawing.Point(400, 250);
            this.lblExams.AutoSize = true;

            // Button to save to file
            this.btnSaveToFile.Text = "Сохранить в файл";
            this.btnSaveToFile.Location = new System.Drawing.Point(30, 450);
            this.btnSaveToFile.Width = 320;

            // Button to load from file
            this.btnLoadFromFile.Text = "Загрузить из файла";
            this.btnLoadFromFile.Location = new System.Drawing.Point(400, 450);
            this.btnLoadFromFile.Width = 320;

            // Label for Event Log
            this.lblEventLog.Text = "Лог событий";
            this.lblEventLog.Location = new System.Drawing.Point(30, 500);
            this.lblEventLog.AutoSize = true;

            // CheckBox for toggling theme
            this.chkToggleTheme.Text = "Тёмная тема";
            this.chkToggleTheme.Location = new System.Drawing.Point(30, 550);
            this.chkToggleTheme.AutoSize = true;
            this.chkToggleTheme.CheckedChanged += new System.EventHandler(this.chkToggleTheme_CheckedChanged);

            // Adding controls to the form
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.lblExamDate);
            this.Controls.Add(this.txtExamDate);
            this.Controls.Add(this.btnAddExam);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.lblExams);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.lblEventLog);
            this.Controls.Add(this.chkToggleTheme);

            // Привязка событий к кнопкам
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblName;
        private MaterialSkin.Controls.MaterialLabel lblSurname;
        private MaterialSkin.Controls.MaterialLabel lblDateOfBirth;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDateOfBirth;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddStudent;
        private MaterialSkin.Controls.MaterialLabel lblSubject;
        private MaterialSkin.Controls.MaterialLabel lblGrade;
        private MaterialSkin.Controls.MaterialLabel lblExamDate;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSubject;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGrade;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtExamDate;
        private MaterialSkin.Controls.MaterialRaisedButton btnAddExam;
        private System.Windows.Forms.ListBox lstStudents;
        private MaterialSkin.Controls.MaterialLabel lblExams;
        private MaterialSkin.Controls.MaterialRaisedButton btnSaveToFile;
        private MaterialSkin.Controls.MaterialRaisedButton btnLoadFromFile;
        private MaterialSkin.Controls.MaterialLabel lblEventLog;
        private MaterialSkin.Controls.MaterialCheckBox chkToggleTheme;
    }
}
