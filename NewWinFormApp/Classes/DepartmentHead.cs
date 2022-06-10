using System;

namespace Company
{
    public class DepartmentHead : Person
    {
        public Department Department
        {
            get => Department;
            set
            {
                if (Department != value)
                {
                    Department = value;
                    value.DepartmentHead = this;
                }
            }
        }

        public DepartmentHead(FullName fullName, DateTime dateBirth, Sex sex)
            : base(fullName, dateBirth, sex)
        {
        }
        
        public DepartmentHead(FullName fullName, DateTime dateBirth, Sex sex, Department department)
            : base(fullName, dateBirth, sex)
        {
            Department = department;
        }
    }
}