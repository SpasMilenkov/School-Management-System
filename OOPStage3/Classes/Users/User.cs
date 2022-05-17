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
        protected List<string> Courses = new();
        public User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }

        public abstract List<string> GetInfo();
        public string[] GetBaseInfo()
        {
            string[] info = new string[] { this.Name, this.Password, this.Email};
            return info;
        }
        public virtual void AddInfo(string paramater)
        {
            Courses.Add(paramater);
        }
        public virtual List<Student> MyStudents()
        {
            List<Student> students = new();
            return students;
        }
        public decimal AverageGrade(List<Grade> grades)
        {
            if (grades.Count == 0)
                return 6M;

            return Math.Floor(grades
                            .Select(g => g.Amount).Average());
        }
        public virtual List<string> GetCourses()
        {
            return Courses;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
