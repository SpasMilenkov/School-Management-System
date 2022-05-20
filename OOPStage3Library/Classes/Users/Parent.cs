using System;
using System.Collections.Generic;

namespace OOPStage3Library.Classes.Users
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
        public override List<string> GetCourses(string lookupParam)
        {
            if(lookupParam == "0")
                return GetCourses();

            return Students[int.Parse(lookupParam)].GetCourses();

        }

        public override void AddInfo(string paramater)
        {
            throw new NotImplementedException();
        }

        public override List<string> GetCourses()
        {
            return Students[0].GetCourses();
        }
    }
}
