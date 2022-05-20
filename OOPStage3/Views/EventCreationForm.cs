using OOPStage3.Classes.Controls;
using OOPStage3.Classes.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPStage3.Classes.Users;

namespace OOPStage3.Views
{
    public partial class EventCreationForm : Form
    {
        private List<string> _properties = new List<string>();
        private int _day;
        private EventControls _controls;
        private User _user;
        public EventCreationForm(int day, EventControls controller, User user)
        {
            InitializeComponent();
            _controls = controller;
            _day = day;
            _user = user;
            labelDay.Text = day.ToString();
            labelMonth.Text = FormCalendar.month.ToString();
            labelYear.Text = FormCalendar.year.ToString();

        }
        private void buttonColor_Click_1(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = cd.Color;
            }
        }

        private void labelConfirm_Click(object sender, EventArgs e)
        {
            if (radioButtonLecture.Checked)
            {
                Lecture lecture = new Lecture(textBoxEventName.Text,
                    richTextBoxDescription.Text,
                    _user.GetBaseInfo()[0],
                    textBoxSubject.Text,
                    textBoxCourse.Text,
                    buttonColor.BackColor);
                _controls.AddEvent(lecture);
                this.BackColor = buttonColor.BackColor;
                this.Close();

            }
            else if (radioButtonLabExc.Checked)
            {
                LabExercise lab = new(textBoxEventName.Text,
                    richTextBoxDescription.Text,
                    _user.GetBaseInfo()[0],
                    textBoxSubject.Text,
                    textBoxCourse.Text,
                    buttonColor.BackColor
                    );
                _controls.AddEvent(lab);
                this.BackColor = buttonColor.BackColor;
                this.Close();
            }
            else
                MessageBox.Show("Select the type of the event");
        }

        private void labelCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
