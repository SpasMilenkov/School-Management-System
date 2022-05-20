using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStage3.Classes.Users
{
    [Serializable]
    public abstract class User
    {
        protected string Name { get; set; }
        protected string Password { get; set; }
        protected string Email { get; set; }

        public User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }
        public string[] GetBaseInfo()
        {
            string[] info = new string[] { this.Name, this.Password, this.Email};
            return info;
        }

        public virtual List<Student> MyStudents()
        {
            List<Student> students = new();
            return students;
        }
        public override string ToString()
        {
            return Name;
        }
        public decimal AverageGrade(List<Grade> grades)
        {
            if (grades.Count == 0)
                return 6M;

            return Math.Floor(grades
                            .Select(g => g.Amount).Average());
        }
        public abstract List<string> GetCourses();
        public abstract List<string> GetCourses(string lookupParam);
        public abstract void AddInfo(string paramater);
        public abstract List<string> GetInfo();
    }
}
