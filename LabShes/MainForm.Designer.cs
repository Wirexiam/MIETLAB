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

        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblExamDate = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtExamDate = new System.Windows.Forms.TextBox();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.lblExams = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(30, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя:";
            // 
            // lblSurname
            // 
            this.lblSurname.Location = new System.Drawing.Point(30, 60);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(100, 23);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Text = "Фамилия:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Location = new System.Drawing.Point(30, 100);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(100, 23);
            this.lblDateOfBirth.TabIndex = 2;
            this.lblDateOfBirth.Text = "Дата рождения:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(120, 60);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(150, 22);
            this.txtSurname.TabIndex = 4;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Location = new System.Drawing.Point(120, 100);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(150, 22);
            this.txtDateOfBirth.TabIndex = 5;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(30, 140);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(240, 30);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Добавить студента";
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.Location = new System.Drawing.Point(30, 190);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(100, 23);
            this.lblSubject.TabIndex = 7;
            this.lblSubject.Text = "Предмет:";
            // 
            // lblGrade
            // 
            this.lblGrade.Location = new System.Drawing.Point(30, 230);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(100, 23);
            this.lblGrade.TabIndex = 8;
            this.lblGrade.Text = "Оценка:";
            // 
            // lblExamDate
            // 
            this.lblExamDate.Location = new System.Drawing.Point(30, 270);
            this.lblExamDate.Name = "lblExamDate";
            this.lblExamDate.Size = new System.Drawing.Size(100, 23);
            this.lblExamDate.TabIndex = 9;
            this.lblExamDate.Text = "Дата экзамена:";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(120, 190);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(150, 22);
            this.txtSubject.TabIndex = 10;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(120, 230);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(150, 22);
            this.txtGrade.TabIndex = 11;
            // 
            // txtExamDate
            // 
            this.txtExamDate.Location = new System.Drawing.Point(120, 270);
            this.txtExamDate.Name = "txtExamDate";
            this.txtExamDate.Size = new System.Drawing.Size(150, 22);
            this.txtExamDate.TabIndex = 12;
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(30, 310);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(240, 30);
            this.btnAddExam.TabIndex = 13;
            this.btnAddExam.Text = "Добавить экзамен";
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // lstStudents
            // 
            this.lstStudents.ItemHeight = 16;
            this.lstStudents.Location = new System.Drawing.Point(300, 20);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(240, 148);
            this.lstStudents.TabIndex = 14;
            // 
            // lblExams
            // 
            this.lblExams.Location = new System.Drawing.Point(300, 190);
            this.lblExams.Name = "lblExams";
            this.lblExams.Size = new System.Drawing.Size(240, 150);
            this.lblExams.TabIndex = 15;
            this.lblExams.Click += new System.EventHandler(this.lblExams_Click);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(30, 360);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(240, 30);
            this.btnSaveToFile.TabIndex = 16;
            this.btnSaveToFile.Text = "Сохранить в файл";
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(300, 360);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(240, 30);
            this.btnLoadFromFile.TabIndex = 17;
            this.btnLoadFromFile.Text = "Загрузить из файла";
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 420);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtDateOfBirth);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblExamDate);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtExamDate);
            this.Controls.Add(this.btnAddExam);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.lblExams);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnLoadFromFile);
            this.Name = "MainForm";
            this.Text = "Работа с экзаменами и студентами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtDateOfBirth;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblExamDate;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.TextBox txtExamDate;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label lblExams;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnLoadFromFile;
        private System.Windows.Forms.Label lblEventLog;
    }
}
