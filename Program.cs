using System;

namespace EmployeeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            double hours;
            double wage;
            string name;
            string id;
            Employee employee;

            name = GetName();

            id = GetID();

            hours = GetHours();

            employee = new Employee(name, id, hours);

            wage = employee.calcWage();

            Console.WriteLine(employee.ToString());
            Console.WriteLine("The Weekly Wage is £" + wage.ToString("F"));
        }

        //Obtains the name of the Employee
        static string GetName()
        {
            string name;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            while (!Employee.IsValidName(name))
            {
                Console.WriteLine("Names must be between 1 and 40 characters (including spaces)");
                Console.WriteLine("Please re-enter your name: ");
                name = Console.ReadLine();
            }
            return name;
        }

        //Obtains the ID of the Employee
        static string GetID()
        {
            string id;
            Console.WriteLine("Please enter your ID: ");
            id = Console.ReadLine();
            while (!Employee.IsValidID(id))
            {
                Console.WriteLine("ID's must be in the format X99 (1 letter then 2 numbers)");
                Console.WriteLine("Please re-enter your ID: ");
                id = Console.ReadLine();
            }
            id = id.ToUpper();
            return id;
        }

        //Obtains the number of hours worked
        static double GetHours()
        {
            double hours;
            Console.WriteLine("Hours worked this Week: ");
            hours = Double.Parse(Console.ReadLine());

            while (!Employee.IsValidHours(hours))
            {
                Console.WriteLine("Hours must be between 1 and 100");
                Console.WriteLine("Hours worked this Week: ");
                hours = Double.Parse(Console.ReadLine());
            }

            return hours;
        }
    }
}
