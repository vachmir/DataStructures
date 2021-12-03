using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class Person
    {
        private string firstName;
        private string lastName;    
        private string email;    

        public string FirstName
        {
            get { return firstName; }
            set {firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get
            {
                if (email!=null)
                {
                    return $"Email is {email}";

                } 
                else
                {
                    return $"{FirstName} does not have an Email";
                }
            }
            set { email = value; }
        }       
    }
}
