using System;
using System.Drawing;

namespace OOPStage3.Classes.Events
{
    public class LabExercise : Event
    {
        public LabExercise(string name, string description, string organizer, string subject, string course, Color color) : base(name, description, organizer, subject, course, color)
        {
            if(DateTime.Now.Month == this.Date.Month && DateTime.Now.Year == this.Date.Year  && this.Date.Day - DateTime.Now.Day <= 3)
                this.Color = Color.FromArgb(253, 164, 0);

            if (DateTime.Now.Month == this.Date.Month && DateTime.Now.Year == this.Date.Year && DateTime.Now > this.Date)
                this.Color = Color.FromArgb(169, 27, 61);

        }
    }
}
