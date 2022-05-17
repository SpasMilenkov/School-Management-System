using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStage3.Classes.Events
{
    public class Lecture : Event
    {
        public Lecture(string name, string description, string organizer, string subject, string course, Color color) : base(name, description, organizer, subject, course, color)
        {
        }
    }
}
