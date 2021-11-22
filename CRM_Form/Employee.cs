using System;

namespace CRM_Form
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Company { get; set; }
        public DateTime BirthDay { get; set; }
        public string PhoneNumber { get; set; }
        public int Number { get; set; }

        public override string ToString() => $"{Name} {Surname}";
    }
}
