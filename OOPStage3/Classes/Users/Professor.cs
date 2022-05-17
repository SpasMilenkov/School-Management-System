using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStage3.Classes.Users
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
    }
}