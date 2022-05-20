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
        protected DateTime Date;
        protected string Name;
        protected string Description;
        protected string Subject;
        protected string Course;
        protected Color Color;
        protected string Organizer;

        public Event(string name, string description, string organizer, string subject, string course, Color color)
        {
            Name = name;
            Description = description;
            Subject = subject;
            Course = course;
            Color = color;
            Organizer = organizer;
        }   
        public List<String> GetEventInfo()
        {
            List<String> eventsInfo = new();
            eventsInfo.Add(Name);
            eventsInfo.Add(Organizer);
            eventsInfo.Add(Subject);
            eventsInfo.Add(Course);
            eventsInfo.Add(Description);
            return eventsInfo;
        }
        public Color GetColor()
        {
            return Color;
        }
        public DateTime GetDate()
        {
            return Date;
        }
    }
}
