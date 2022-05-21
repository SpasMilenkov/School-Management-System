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
            Teaches.Add(paramater);
        }

        public override List<string> GetCourses()
        {
            return Teaches;
        }

        public override List<string> GetCourses(string lookupParam)
        {
            return Teaches;
        }

        public override List<string> GetInfo()
        {
            List<string> info = new();
            if (IsTeacher == true)
                info.Add("IsProf");

            info.Add(Title);
            return info;
        }
    }
}
