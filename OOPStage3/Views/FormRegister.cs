using OOPStage3.Classes.Controls;
using OOPStage3.Classes.Users;
using OOPStage3.Properties;
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

namespace OOPStage3.Views
{
    public partial class FormRegister : Form
    {
        private UserControls _userControls;
        private List<Student> _children = new();
        private List<string> ids = new();
        public FormRegister(UserControls vault)
        {
            InitializeComponent();
            this.BackgroundImage = Resources.theme1;
            panelNavigation.BackColor = Color.FromArgb(200, 14, 65, 88);
            _userControls = vault;
        }
        private void labelAddMore_Click(object sender, EventArgs e)
        {
            ids.Add(textBoxID.Text);
            textBoxID.Clear();
        }

        private void FormRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            _userControls.SaveUserData();
        }

        private void labelExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelConfirm_Click(object sender, EventArgs e)
        {
            _children = _userControls.FindStudents(ids);
            Random random = new Random();
            bool valid = true;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && control.Text == "" && control != textBoxID && _children.Count != 0)
                    valid = false;
            }
            if (valid)
            {
                Parent parent = new Parent(textBoxName.Text, textBoxPassword.Text, textBoxEmail.Text, _children);
                this.Hide();
                _userControls.AddUser(parent);
                FormDashboard dashboard = new FormDashboard(parent, _userControls);
                this.Hide();
                dashboard.FormClosed += (s, e) => this.Close();
                _userControls.AddUser(parent);
                dashboard.Show();
                return;
            }
            MessageBox.Show("Invalid input! Make sure all fields are filled!");
        }

        private void labelLogin_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new FormLogin()));
            t.Start();
            this.Close();
        }
    }
}
