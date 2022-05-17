using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStage3.Classes.Users
{
    [Serializable]
    public class Parent : User
    {
        public List<Student> Students = new();

        public Parent(string name, string password, string email, List<Student> students) : base(name, password, email)
        {
            Students = students;
        }

        public override List<string> GetInfo()
        {
            throw new NotImplementedException();
        }
        public override List<Student> MyStudents()
        {
            return Students;
        }
    }
}
