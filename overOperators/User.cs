using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overOperators
{
    internal class User
    {
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }

        public User(string n)
        {
            Name = n;
            RegistrationDate = DateTime.Now;
        }

        public override string ToString()
        {
            return new string($"User: {Name} registered {RegistrationDate}");
        }

        public static bool operator > (User u1, User u2)
        {
            if (u1.RegistrationDate > u2.RegistrationDate) return true;
            else return false;
        }

        public static bool operator < (User u1, User u2)
        {
            if (u1.RegistrationDate < u2.RegistrationDate) return true;
            else return false;
        }
    }
}
