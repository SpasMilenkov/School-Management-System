using OOPStage3.Classes;
using OOPStage3.Classes.Controls;
using OOPStage3.Classes.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace OOPStage3.Views
{
    public partial class EditsForm : Form
    {
        private List<User> _users = new();
        private List<Grade> _grades = new();
        private List<String> _subjects = new();
        private UserControls _controls = new();
        private User _user;
        public EditsForm(UserControls controls, Color backcolor, User user)
        {
            InitializeComponent();
            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
              BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
              null, panelForm, new object[] { true });
            _controls = controls;
            _user = user;
            listBoxUsers.BackColor = Color.FromArgb(backcolor.R, backcolor.G, backcolor.B);
            labelConfirm.BackColor = backcolor;
            labelAdd.BackColor = backcolor;
            labelCancel.BackColor = backcolor;
            panel1.BackColor = backcolor;
            panelForm.BackColor = backcolor;
            radioButtonGrades.Checked = true;
            if (user is Professor)
            {
                radioButtonCourses.Visible = false;
                radioButtonStaff.Visible = false;
                radioButtonStudents.Visible = false;
            }
        }

        private void labelAdd_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in panelForm.Controls)
                if ( item is TextBox && item.Visible == true && item.Text == String.Empty)
                {
                    MessageBox.Show("Fill all fields first!");
                    return;
                }

            if (radioButtonStudents.Checked)
            {
                Student student = new(textBox2.Text, textBox3.Text, textBox4.Text, textBox1.Text, textBox6.Text);
                student.AddInfo(textBox5.Text);
                _users.Add(student);
                listBoxUsers.Items.Add(student.GetInfo()[0]);
                return;
            }
            if (radioButtonStaff.Checked)
            {
                Professor prof = new(textBox2.Text, textBox3.Text, textBox4.Text, label1.Text);
                _users.Add(prof);
                listBoxUsers.Items.Add(textBox2.Name);
                listBoxUsers.Refresh();
                return;
            }
            if (radioButtonCourses.Checked)
            {
                if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
                {
                    _subjects.Add(textBox2.Text);
                    listBoxUsers.Items.Add(textBox2.Text);
                    textBox2.Clear();
                    return;
                }
                MessageBox.Show("Invalid input try again!");
                return;
            }
            if (radioButtonGrades.Checked)
            {
                listBoxUsers.DataSource = _grades;
                Grade grade = new(decimal.Parse(textBox3.Text),
                                                textBox4.Text,
                                                textBox1.Text,
                                                _user.GetBaseInfo()[0],
                                                DateTime.Now);
                listBoxUsers.Items.Add($"{grade.Amount.ToString()}{grade.OwnerID}{grade.Subject}");
                listBoxUsers.Refresh();
                _grades.Add(grade);
                return;
            }
            MessageBox.Show("Please check at least one of the boxes!");

        }

        private void labelConfirm_Click_1(object sender, EventArgs e)
        {
            foreach (var user in _users)
                _controls.AddUser(user);

            foreach (var grade in _grades)
                _controls.AddGrade(grade);
            _controls.AddCourse(textBox1.Text, _subjects);
            DialogResult = DialogResult.OK;
        }

        private void labelCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void radioButtonGrades_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Amount: ";
            label4.Text = "Subject: ";
            textBox6.Visible = false;
            textBox5.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox4.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            this.labelAdd.Location = new Point(300, 390);
        }

        private void radioButtonStudents_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "ID: ";
            label2.Text = "Name: ";
            label4.Text = "E-mail: ";
            label3.Text = "Password: ";
            label5.Text = "Course: ";
            
            textBox6.Visible = true;
            textBox5.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox4.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            this.labelAdd.Location = new Point(300, 390);
        }

        private void radioButtonStaff_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Title: ";
            label2.Text = "Name: ";
            label4.Text = "E-mail: ";
            label3.Text = "Password: ";
            label5.Text = "Teaches: ";
            textBox6.Visible = true;
            textBox5.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            textBox6.Visible = false;
            textBox4.Visible = true;
            textBox3.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            this.labelAdd.Location = new Point(300, 390);
        }

        private void radioButtonCourses_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Name of the semester:";
            label2.Text = "Subjects in this course:";
            textBox5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            textBox4.Visible = false;
            textBox3.Visible = false;
            textBox6.Visible = false;

            this.labelAdd.Location = new Point(275, 135);
        }
    }
}
