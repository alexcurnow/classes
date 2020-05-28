using System;

namespace classes
{
    class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string firstName, string lastName, string title, DateTime date)
        {
            Firstname = firstName;
            Lastname = lastName;
            Title = title;
            StartDate = date;
        }
    }
}