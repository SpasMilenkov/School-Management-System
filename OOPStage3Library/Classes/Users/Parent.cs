using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPStage3Library.Classes.Users
{
    [Serializable]
    public class Parent : User
    {
        private List<Student> Students = new();
        private string Address;
        private string Phone;
        public Parent(string name, string password, string email, string address, string phone, List<Student> students) : base(name, password, email)
        {
            Students = students;
            Address = address;
            Phone = phone;
        }

        public override List<string> GetInfo()
        {
            List<string> info = new List<string>();
            info.Add(Address);
            info.Add(Phone);
             
            return info; 
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
           
        }

        public override List<string> GetCourses()
        {
            return Students[0].GetCourses();
        }
    }
}
