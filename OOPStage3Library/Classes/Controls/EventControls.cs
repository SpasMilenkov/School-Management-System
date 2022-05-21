using OOPStage3Library.Classes.Events;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOPStage3Library.Classes.Controls
{
    [Serializable]
    public class EventControls
    {
        private static List<Event> _events = new();
        public void AddEvent(Event customEvent)
        {
            _events.Add(customEvent);
        }
        public List<Event> GetEvent(int day, int month, int year)
        {
            List<Event> events = new();
            foreach (Event customEvent in _events)
            {
                DateTime date = customEvent.GetDate();
                if (date.Day == day && date.Month == month && date.Year == year)
                    events.Add(customEvent);
            }
            return events;
        }
        public bool EventExists(int day, int month, int year)
        {
            foreach (Event customeEvent in _events)
            {
                DateTime date = customeEvent.GetDate();
                if (date.Day == day && date.Month == month && date.Year == year)
                    return true;
            }
            return false;
        }

        public void SaveEvents()
        {
            IFormatter formatter = new BinaryFormatter();

            using var fs = new FileStream("EventData", FileMode.Create);
            formatter.Serialize(fs, _events);
        }

        public void LoadEvents()
        {
            if (!File.Exists("data"))
                return;

            IFormatter formatter = new BinaryFormatter();
            using var fs = new FileStream("EventdData", FileMode.Open);
            _events = (List<Event>)formatter.Deserialize(fs);
        }
    }
}
