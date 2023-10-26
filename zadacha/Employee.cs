using System.Collections.Generic;

namespace zadacha
{
    internal class Employee
    {
        public string Name { get; set; }
        public List<Employee> Subordinates { get; set; }

        public Employee(string name)
        {
            Name = name;
            Subordinates = new List<Employee>();
        }
    }
}

