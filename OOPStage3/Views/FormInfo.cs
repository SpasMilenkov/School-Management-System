using OOPStage3Library.Classes;
using OOPStage3Library.Classes.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPStage3.Views
{
    public partial class FormInfo : Form
    {
        private User _user;
        private Grade _grade;
        public FormInfo(Color maincolor, User user)
        {
            InitializeComponent();
            panelWrapper.BackColor = maincolor;
            _user = user;
        }
        public FormInfo(Color maincolor, Grade grade)
        {
            InitializeComponent();
            panelWrapper.BackColor = maincolor;
            _grade = grade;
        }
        private void FormInfo_Load(object sender, EventArgs e)
        {
            if(_user == null)
            {
                labelName.Text = $"Owner ID: {_grade.OwnerID}";
                labelMail.Text = $"Graded by: {_grade.GradedBy}";
                label1.Text = $"Subject: {_grade.Subject}";
                label2.Text = $"Amount: {_grade.Amount}";
                label3.Text = $"On: {_grade.Date}";
                return;
            }

            var baseInfo = _user.GetBaseInfo();
            labelName.Text = $"Name: {baseInfo.First()}";
            labelMail.Text = $"Email: {baseInfo.Last()}";
            if(_user is Student)
            {
                var info = _user.GetInfo();
                label1.Text = $"ID: {info.First()}" ;
                label2.Text = $"Group: {info.Last()}";
                label3.Text = $"Current course: {_user.GetCourses().Last()}";
            }
            if(_user is Professor)
            {
                var info = _user.GetInfo();
                label1.Text = $"Title: {info.First()}";
                label2.Text = $"Teaches: {info.Last()}";
                label3.Visible = false;
            }
            if(_user is Parent)
            {
                var info = _user.GetInfo();
                label1.Text = $"Address: {info.First()}";
                label2.Text = $"Phone number: {info.Last()}";
                label3.Visible= false;
            }
        }
    }
}
