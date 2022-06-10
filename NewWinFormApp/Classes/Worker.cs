using System;

namespace Company
{
    public class Worker : Person
    {
        public DepartmentHead DepartmentHead { get; set; }


        public Worker(FullName fullName, DateTime dateBirth, Sex sex, DepartmentHead departmentHead)
            : base(fullName, dateBirth, sex)
        {
            DepartmentHead = departmentHead;
        }
    }
}