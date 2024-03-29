﻿using System;
using System.Collections.Generic;

namespace OOPStage3Library.Classes.Users
{
    [Serializable]
    public class Professor : User
    {
        private List<string> Teaches = new();

        private string Title;
        public Professor(string name, string password, string email, string title) : base(name, password, email)
        {
            Title = title;
        }

        public override List<string> GetInfo()
        {
            List<string> info = new();
            info.Add(Title);
            info.AddRange(Teaches);
            return info;
        }
        public override List<string> GetCourses()
        {
            return Teaches;
        }

        public override void AddInfo(string paramater)
        {
            Teaches.Add(paramater);
        }

        public override List<string> GetCourses(string lookupParam)
        {
            return GetCourses();
        }
    }
}