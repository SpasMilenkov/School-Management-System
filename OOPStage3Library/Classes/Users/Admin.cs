using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStage3Library.Classes.Users
{
    [Serializable]
    public class Admin : User
    {
        public Admin(string name, string password, string email) : base(name, password, email)
        {
        }

        public override void AddInfo(string paramater)
        {
            throw new NotImplementedException();
        }

        public override List<string> GetCourses()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetCourses(string lookupParam)
        {
            throw new NotImplementedException();
        }

        public override List<string> GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
