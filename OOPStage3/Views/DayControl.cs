using OOPStage3.Classes.Controls;
using OOPStage3.Classes.Events;
using OOPStage3.Classes.Users;
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
        private readonly User _user;
        public DayControl(User user)
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer, true);
            int day = Convert.ToInt32(labelCustomEvent.Text);
            this.ForeColor = Color.White;
            this.BackColor = Color.FromArgb(100, 0, 0, 0);
            _user = user;
            if (_eventControls.EventExists(day))
            {
                var firstEvent = _eventControls.GetEvent(int.Parse(labelCustomEvent.Text)).First();
                this.BackColor = Color.FromArgb(100, firstEvent.GetColor());
            }
            label.Text = "";

        }

        public void Days(int numday)
        {
            labelCustomEvent.Text = numday + "";
            if (_customEvent != null)
                label.Text = _user.GetBaseInfo()[0];
        }
        private void DayControl_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            EventCreationForm eventFillForm = new EventCreationForm(int.Parse(labelCustomEvent.Text), _eventControls, _user);
            eventFillForm.FormClosed += (s, e) =>
            {
                if (_eventControls.GetEvent(int.Parse(labelCustomEvent.Text)).Count() != 0)
                {

                    this.BackColor = eventFillForm.BackColor;
                    label.Text = _user.GetBaseInfo()[0];
                }
            };  
            eventFillForm.ShowDialog();
        }
    }
}
