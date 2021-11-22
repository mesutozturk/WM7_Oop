using System.Collections.Generic;

namespace CRM_Form
{
    public class EmployeeContext
    {
        public List<Employee> EmployeList { get; set; } = new();

        public static void Generate(ref List<Employee> employees, int count)
        {
            //employees = employees ?? new();
            employees ??= new();
            //count = count + 2;
            //count += 2;
            for (int i = 0; i < count; i++)
            {
                var employee = new Employee()
                {
                    Name = Faker.Name.First(),
                    Surname = Faker.Name.Last(),
                    Address = $"{Faker.Address.StreetAddress()} {Faker.Address.City()} {Faker.Address.Country()}",
                    BirthDay = Faker.Identification.DateOfBirth(),
                    Company = Faker.Company.Name(),
                    Number = Faker.RandomNumber.Next(10, 100),
                    PhoneNumber = Faker.Phone.Number()
                };
                employees.Add(employee);
            }
        }
    }
}
