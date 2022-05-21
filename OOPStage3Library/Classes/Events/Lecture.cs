using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStage3Library.Classes.Events
{
    public class Lecture : Event
    {
        public Lecture(string name, string description, string organizer, string subject, string course, Color color, DateTime date) : base(name, description, organizer, subject, course, color, date)
        {
            if (DateTime.Now.Month == this.Date.Month && DateTime.Now.Year == this.Date.Year && this.Date.Day - DateTime.Now.Day <= 3)
                this.Color = Color.FromArgb(253, 164, 0);
        }
    }
}
