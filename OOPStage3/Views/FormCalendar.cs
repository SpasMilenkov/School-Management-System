using System;
using System.Drawing;
using System.Windows.Forms;
using OOPStage3.Properties;
using System.Reflection;
using System.Globalization;
using OOPStage3Library.Classes.Users;

namespace OOPStage3.Views
{
    public partial class FormCalendar : Form
    {
        public static int _month, _year;
        private User _user;
        //private EventControls _eventControls;

        public FormCalendar(byte s, User user)
        {
            InitializeComponent();
            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
                          BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                          null, flowLayoutPanelDays, new object[] { true });
            _user = user;
            switch (s)
            {
                case 1: this.BackgroundImage = Resources.theme1; break;
                case 2: this.BackgroundImage = Resources.theme2; break;
                case 3: this.BackgroundImage = Resources.theme3; break;
                case 4: this.BackgroundImage = Resources.theme4; break;
                case 5: this.BackgroundImage = Resources.theme5; break;
            }
            this.ForeColor = Color.White;

        }
        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            _month = now.Month;
            _year = now.Year;
        }
        private void FormCalendar_Load(object sender, EventArgs e)
        {
            DisplayDays();
            FillCalendar(_month, _year);
        }

        private void labelNext_Click(object sender, EventArgs e)
        {
            //clear the day containers
            flowLayoutPanelDays.Controls.Clear();
            _month++;
            if (_month == 13)
            {
                _year++;
                _month = 1;
            }

            FillCalendar(_month, _year);
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            //clear the day containers
            flowLayoutPanelDays.Controls.Clear();
            _month--;
            //getting the first day of the month
            if (_month == 0)
            {
                _year--;
                _month = 12;
            }
            FillCalendar(_month, _year);
        }

        public void FillCalendar(int month, int year)
        {
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            labelMonthAndYear.Text = monthName + " " + year;


            DateTime firstDayOfMonth = new(year, month, 1);

            //count of days
            int daysCount = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(firstDayOfMonth.DayOfWeek.ToString("d"));


            for (int i = 0; i < dayOfTheWeek; i++)
            {
                BlankUserControl blankUserControl = new BlankUserControl();
                flowLayoutPanelDays.Controls.Add(blankUserControl);
            }

            for (int i = 1; i <= daysCount; i++)
            {
                DayControl ucdays = new(_user, month, year);
                ucdays.Days(i);
                flowLayoutPanelDays.Controls.Add(ucdays);
            }

        }
    }
}
