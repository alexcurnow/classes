using System;
using System.Collections.Generic;

namespace classes
{
    class Company
    {
        public DateTime DateFounded { get; }
        public string CompanyName { get; }
        public List<Employee> employees = new List<Employee>();
        public Company(string name, DateTime date)
        {
            CompanyName = name;
            DateFounded = date;
        }
        public void ListEmployees()
        {
            employees.ForEach(employee =>
                Console.WriteLine($"{employee.Firstname} {employee.Lastname} works for {CompanyName} as a {employee.Title} since {employee.StartDate.Date}"));
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}