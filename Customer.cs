using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        //any class can get this id but only this class can set it. 
        public int CustomerId { get; private set; }

        public string EmailAddress { get;    set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + Firstname;
            }
        }
        //public string FirstName(get;set;}
        private string _firstName;
        public string Firstname
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        //public string LastName(get;set;}

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
}
