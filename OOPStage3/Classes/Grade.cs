using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStage3.Classes
{
    [Serializable]
    public class Grade
    {
        public readonly decimal Amount;
        public readonly string Subject;
        public readonly string OwnerID;
        public readonly string GradedBy;
        public readonly DateTime Date;
        public Grade(decimal amount, string subject, string ownerID, string gradedBy, DateTime date)
        {
            Amount = amount;
            Subject = subject;
            OwnerID = ownerID;
            GradedBy = gradedBy;
            Date = date;
        }
    }
}