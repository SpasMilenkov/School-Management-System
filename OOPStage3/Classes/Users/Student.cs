using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStage3.Classes.Users
{
    [Serializable]
    public class Student : User
    {
        private string _id;
        private readonly string _group;
        protected List<string> Courses = new();
        public Student(string name, string password, string email, string id, string group) : base(name, password, email)
        {
            _id = id;
            _group = group;

        }
        public override List<string> GetInfo()
        {
            List<string> info = new();
            info.Add(_id);
            info.Add(_group);
            info.AddRange(Courses);
            return info;
        }

        public override void AddInfo(string paramater)
        {
          Courses.Add(paramater);
        }

        public override List<string> GetCourses()
        {
            return Courses;
        }

        public override List<string> GetCourses(string lookupParam)
        {
            return GetCourses();
        }
    }
}
