using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntermediaryAccessModifiers
{
    public class Person
    {
        //like private we can't access birthdate outside person class
        //We need a method to make it happend
        private DateTime _birthdate; //private birthdate field
        
        //method that provides access to birthdate field
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }
        //method that provides access to birthdate field
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}