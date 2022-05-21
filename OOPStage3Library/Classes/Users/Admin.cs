using System;
using System.Collections.Generic;

namespace OOPStage3Library.Classes.Users
{
    [Serializable]
    public class Admin : User
    {
        private List<string> Teaches = new();
        private string Title;
        private bool IsTeacher = false;
        public Admin(string name, string password, string email) : base(name, password, email)
        {
        }
        public Admin(string name, string password, string email,string title, List<string> teaches) : base(name, password, email)
        {
            Title = title;
            Teaches = teaches;
            IsTeacher = true;
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
