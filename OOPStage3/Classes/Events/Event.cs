using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOPStage3.Classes.Events
{
    public class Event
    {
        public DateTime Date;
        public string Name;
        public string Description;
        public string Subject;
        public string Course;
        public Color Color;
        public string Organizer;

        public Event(string name, string description, string organizer, string subject, string course, Color color)
        {
            Name = name;
            Description = description;
            Subject = subject;
            Course = course;
            Color = color;
            Organizer = organizer;
        }

    }
}
