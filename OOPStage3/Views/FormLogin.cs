using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPStage3.Properties;
using OOPStage3.Views;
using OOPStage3Library.Classes;
using OOPStage3Library.Classes.Controls;
using OOPStage3Library.Classes.Users;

namespace OOPStage3
{
    public partial class FormLogin : Form
    {
        private UserControls vault = new UserControls();
        public FormLogin()
        {
            InitializeComponent();
            this.BackgroundImage = Resources.theme1;
            panelBackground.BackColor = Color.FromArgb(200, 14, 65, 88);
            this.BackColor = Color.FromArgb(47, 49, 54);
            this.ForeColor = Color.White;
            label1.BackColor = Color.FromArgb(14, 65, 88);

            //Testing purposes


            Student student = new("Meesho", "Marinata", "testmail", "001", "76"); List<Student> students = new();
            List<string> ids = new() { "001" };
            students.AddRange(vault.FindStudents(ids));
            Parent parent = new("Test parent", "Marinata", "testmail1", students);
            Professor professor = new("Test professor", "Marinata", "testmail1", "test title");
            Admin admin = new("Test admin", "Marinata", "testmail");

            vault.AddUser(student);
            vault.AddUser(parent);
            vault.AddUser(professor);
            vault.AddUser(admin);

            for (int i = 3; i < 6; i++)
            {
                Grade grade = new(i, "OOP", "002", "Test professor", DateTime.Now);
                vault.AddGrade(grade);
            }
            Grade grade1 = new(6, "MA2", "002", "Test professor", DateTime.Now);
            vault.AddGrade(grade1);
            Grade grade2 = new(2, "MA2", "002", "Test professor", DateTime.Now);
            vault.AddGrade(grade2);
            Grade grade3 = new(4, "MA2", "002", "Test professor", DateTime.Now);
            vault.AddGrade(grade3);

        }

        private void labelRegister_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new FormRegister(vault)));
            t.Start();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(vault.GetUser(textBoxUName.Text, maskedTextBoxPassword.Text) != null)
            {
                var t = new Thread(() => Application.Run(new FormDashboard(vault.GetUser(textBoxUName.Text, maskedTextBoxPassword.Text), vault)));
                t.Start();
                this.Close();
                return;
            }
            MessageBox.Show("Incorrent credentials. Please try again.");

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            vault.GetUserData();
            vault.GetCourseData();
            vault.GetGradesData();
            List<string> teaches = new() { "OOP" };
            Admin admin1 = new("Alexander Petkov", "Ventrologfist1", "TUmail", "Chief Asistant", teaches);
            vault.AddUser(admin1);
        }
    }
}
