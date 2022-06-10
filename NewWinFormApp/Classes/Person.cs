using System;

namespace Company
{
    public abstract class Person
    {
        public FullName FullName { get; set; }
        public readonly DateTime DateBirth;
        public readonly Sex Sex;
        
        public Person(FullName fullName, DateTime dateBirth, Sex sex)
        {
            FullName = fullName;
            DateBirth = dateBirth.Date;
            Sex = sex;
        }

        public override string ToString()
        {
            return $"{FullName}";
        }
        
    }
}