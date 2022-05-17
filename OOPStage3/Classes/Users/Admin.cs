using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStage3.Classes.Users
{
    [Serializable]
    public class Admin : User
    {
        public Admin(string name, string password, string email) : base(name, password, email)
        {
        }

        public override List<string> GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}
