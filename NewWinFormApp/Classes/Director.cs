using System;

namespace Company
{
    public class Director : Person
    {
        public Director(FullName fullName, DateTime dateBirth, Sex sex)
            : base(fullName, dateBirth, sex)
        {
        }
    }
}