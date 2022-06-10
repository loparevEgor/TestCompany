using System.Collections.Generic;

namespace Company
{
    public class Department
    {
        public string Name { get; set; }

        public DepartmentHead DepartmentHead
        {
            get => DepartmentHead;
            set
            {
                if (DepartmentHead != value)
                {
                    DepartmentHead = value;
                    value.Department = this;
                }
            }
        }

        public List<Person> Workers { get; set; }

        public Department(string name)
        {
            Name = name;
        }
        
        public Department(string name, DepartmentHead departmentHead)
            : this(name)
        {
            DepartmentHead = departmentHead;
        }

        public Department(string name, List<Person> workers) 
            : this(name)
        {
            Workers = workers;
        }

        public Department(string name, DepartmentHead departmentHead, List<Person> workers)
            : this(name, departmentHead)
        {
            Workers = workers;
        }
    }
}