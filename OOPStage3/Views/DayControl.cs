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

namespace OOPStage3.Views
{
    public partial class DayControl : UserControl
    {
        private Event _customEvent;
        private EventControls _eventControls = new();
        public DayControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer, true);
            int day = Convert.ToInt32(labelCustomEvent.Text);
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(100, 0, 0, 0);
            if (_eventControls.EventExists(day))
            {
                var firstEvent = _eventControls.GetEvent(int.Parse(labelCustomEvent.Text)).First();
                //string[] splitter = firstEvent.Color.Split(',');
                this.BackColor = Color.FromArgb(100, firstEvent.Color);
            }
            label.Text = "";

        }

        public void Days(int numday)
        {
            labelCustomEvent.Text = numday + "";
            if (_customEvent != null)
                label.Text = _customEvent.Name;
        }

        private void DayControl_Load(object sender, EventArgs e)
        {

        }

        private void DayControl_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            EventCreationForm eventFillForm = new EventCreationForm(int.Parse(labelCustomEvent.Text), _eventControls);
            eventFillForm.FormClosed += (s, e) =>
            {
                if (_customEvent != null)
                {
                    _customEvent = _eventControls.GetEvent(int.Parse(labelCustomEvent.Text)).First();
                    if (_customEvent != null)
                    {
                        this.BackColor = eventFillForm.BackColor;
                        label.Text = _customEvent.Name;
                    }
                }

            };
            eventFillForm.ShowDialog();
        }
    }
}
