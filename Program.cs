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

            name = GetName();

            id = GetID();

            hours = GetHours();

            wage = CalcWage(hours);

            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("The Weekly Wage is £" + wage.ToString("F"));
        }

        //Verifies the length of the name
        static Boolean IsValidName(string name)
        {
            if (name.Length < 41 && name.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Obtains the name of the Employee
        static string GetName()
        {
            string name;
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            while (!IsValidName(name))
            {
                Console.WriteLine("Names must be between 1 and 40 characters (including spaces)");
                Console.WriteLine("Please re-enter your name: ");
                name = Console.ReadLine();
            }
            return name;
        }

        //Verifies if the ID is correct
        static Boolean IsValidID(String id)
        {
            char[] idArray = id.ToCharArray();

            if (id.Length == 3)
            {
                if (Char.IsLetter((char)idArray.GetValue(0)))
                {
                    if (Char.IsDigit((char)idArray.GetValue(1)))
                    {
                        if (Char.IsDigit((char)idArray.GetValue(2)))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        //Obtains the ID of the Employee
        static string GetID()
        {
            string id;
            Console.WriteLine("Please enter your ID: ");
            id = Console.ReadLine();
            while (!IsValidID(id))
            {
                Console.WriteLine("ID's must be in the format X99 (1 letter then 2 numbers)");
                Console.WriteLine("Please re-enter your ID: ");
                id = Console.ReadLine();
            }
            id = id.ToUpper();
            return id;
        }

        //Verifies that the number of Hours is valid
        static Boolean IsHoursValid(double hours)
        {
            if (hours <= 100 && hours >= 1)
            {
                return true;
            }
            return false;
        }

        //Obtains the number of hours worked
        static double GetHours()
        {
            double hours;
            Console.WriteLine("Hours worked this Week: ");
            hours = Double.Parse(Console.ReadLine());

            while(!IsHoursValid(hours))
            {
                Console.WriteLine("Hours must be between 1 and 100");
                Console.WriteLine("Hours worked this Week: ");
                hours = Double.Parse(Console.ReadLine());
            }

            return hours;
        }

        //Calculates the correct wage
        static double CalcWage(double hours)
        {
            double wage;

            if (hours < 41)
            {
                wage = hours * 9.50;
            }
            else
            {
                wage = (40 * 9.5) + ((hours - 40) * 14.25);
            }

            return wage;
        }
    }
}
