using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string PhoneNumber { get; set; }
        private string Email { get; set; }
        
        public string Name
        {
            get
            {
                string fullName = $"{_firstName} {_lastName}";
                return string.IsNullOrWhiteSpace(fullName) ? "Unnamed" : fullName;
                //return fullName;
                

            }
        }

        public void SetFirstName(string name)
        {
            _firstName = name;
        }

        public void SetLastName(string name)
        {
            _lastName = name;
        }
    }
}
