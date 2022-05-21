using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OOPStage3Library.Classes.Controls;
using OOPStage3Library.Classes.Events;
using OOPStage3Library.Classes.Users;

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
            labelMonth.Text = FormCalendar._month.ToString();
            labelYear.Text = FormCalendar._year.ToString();

        }
        private void buttonColor_Click_1(object sender, EventArgs e)
        {
            var cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = cd.Color;
            }
        }
        //Just add the datetime as arguments 
        private void labelConfirm_Click(object sender, EventArgs e)
        {
            DateTime date = new(int.Parse(labelYear.Text), int.Parse(labelMonth.Text), int.Parse(labelDay.Text));
            if (radioButtonLecture.Checked)
            {
                Lecture lecture = new Lecture(textBoxEventName.Text,
                    richTextBoxDescription.Text,
                    _user.GetBaseInfo()[0],
                    textBoxSubject.Text,
                    textBoxCourse.Text,
                    buttonColor.BackColor,
                    date
                    );
                _controls.AddEvent(lecture);
                this.BackColor = buttonColor.BackColor;
                this.Close();
                _controls.SaveEvents();
            }
            else if (radioButtonLabExc.Checked)
            {
                LabExercise lab = new(textBoxEventName.Text,
                    richTextBoxDescription.Text,
                    _user.GetBaseInfo()[0],
                    textBoxSubject.Text,
                    textBoxCourse.Text,
                    buttonColor.BackColor,
                    date
                    );
                _controls.AddEvent(lab);
                this.BackColor = buttonColor.BackColor;
                this.Close();
                _controls.SaveEvents();
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
