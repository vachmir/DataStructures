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
        private string email = String.Empty;  

        public string FirstName
        {
            get
            {
                char lastSymbol = firstName.First();
                switch (lastSymbol)
                {
                    case 'Ա':
                    case 'Է':
                    case 'Ը':
                    case 'Ի':
                    case 'Ո':
                    case 'Օ':
                        return $"Անունն {firstName} է";
                }
                return $"Անունը {firstName} է";
            }
            set {firstName = value; }
        }

        public string LastName
        {
            get
            {
                char firstSymbol = lastName.First();
                switch (firstSymbol)
                {
                    case 'Ա':
                    case 'Է':
                    case 'Ը':
                    case 'Ի':
                    case 'Ո':
                    case 'Օ':
                        return $"Աազգանունն՝ {lastName}";
                    default:
                        return $"Աազգանունը՝ {lastName}";
                }
            }

            set { lastName = value; }
        }

        public string Email
        {
            get
            {
                if (email!= String.Empty)
                {
                    char lastSymbol = firstName.Last();
                    switch (lastSymbol)
                    {
                        case 'ա':
                        case 'ո':
                            return $"{firstName}յի էլ․ հասցեն է {email}";                            
                        default:
                            return $"{firstName}ի էլ․ հասցեն է {email}";                            
                    }
                } 
                else
                {
                    return $"{firstName}ն էլ․ հասցե չունի";
                }
            }
            set { email = value; }
        }       
    }
}
