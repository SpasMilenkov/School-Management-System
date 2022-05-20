using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPStage3.Properties;
using System.Reflection;
using OOPStage3.Classes.Controls;
using OOPStage3.Classes.Events;
using System.Globalization;

namespace OOPStage3.Views
{
    public partial class FormCalendar : Form
    {
        public static int month, year;
        //private EventControls _eventControls;

        public FormCalendar(byte s)
        {
            InitializeComponent();
            typeof(FlowLayoutPanel).InvokeMember("DoubleBuffered",
                          BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
                          null, flowLayoutPanelDays, new object[] { true });
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
            month = now.Month;
            year = now.Year;
        }
        private void FormCalendar_Load(object sender, EventArgs e)
        {
            DisplayDays();
            FillCalendar(month, year);
        }

        private void labelNext_Click(object sender, EventArgs e)
        {
            //clear the day containers
            flowLayoutPanelDays.Controls.Clear();
            month++;
            if (month == 13)
            {
                year++;
                month = 1;
            }

            FillCalendar(month, year);
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            //clear the day containers
            flowLayoutPanelDays.Controls.Clear();
            month--;
            //getting the first day of the month
            if (month == 0)
            {
                year--;
                month = 12;
            }
            FillCalendar(month, year);
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
                DayControl ucdays = new();
                ucdays.Days(i);
                flowLayoutPanelDays.Controls.Add(ucdays);
            }

        }
    }
}
