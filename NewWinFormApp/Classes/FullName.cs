using System;

namespace Company
{
    public class FullName
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }

        public FullName(string name, string surname, string middleName)
        {
            Name = name;
            Surname = surname;
            MiddleName = middleName;
        }

        public override string ToString()
        {
            return $"{Surname} {Name} {MiddleName}";
        }
    }
}