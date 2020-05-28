using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company paddysPub = new Company("Paddy's Pub", new DateTime(2015, 8, 13));

            Employee charlie = new Employee("Charlie", "Day", "Janitor", new DateTime(2017, 5, 27));
            Employee dee = new Employee("Dee", "Reynolds", "Bartender", new DateTime(2019, 4, 2));
            Employee mac = new Employee("Mac", "...just Mac", "Bouncer", new DateTime(2015, 9, 14));

            paddysPub.AddEmployee(charlie);
            paddysPub.AddEmployee(dee);
            paddysPub.AddEmployee(mac);

            paddysPub.ListEmployees();
        }
    }
}