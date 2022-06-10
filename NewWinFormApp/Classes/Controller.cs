using System;

namespace Company
{
    public class Controller : Person
    {
        public Controller(FullName fullName, DateTime dateBirth, Sex sex) 
            : base(fullName, dateBirth, sex)
        {
        }
    }
}