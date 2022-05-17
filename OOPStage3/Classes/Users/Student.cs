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
    }
}
