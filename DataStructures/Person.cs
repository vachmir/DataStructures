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
            get { return $"First Name is {firstName}"; }
            set {firstName = value; }
        }
        public string LastName
        {
            get { return $"Last Name is {lastName}"; }
            set { lastName = value; }
        }
        public string Email
        {
            get
            {
                if (email!=null)
                {
                    return $"{firstName}'s email is {email}";

                } 
                else
                {
                    return $"{firstName} does not have an email";
                }
            }
            set { email = value; }
        }       
    }
}
