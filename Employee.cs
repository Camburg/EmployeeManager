using System;

public class Employee
{
    string name;
    string id;
    double hours;
    double rate;

	public Employee(string n, string i, double h)
	{
        name = n;
        id = i;
        hours = h;
        rate = 9.5;
	}

    //Outputs a string of the Employee's Details
    string toString()
    {
        return name + id;
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

    //Verifies that the number of Hours is valid
    static Boolean IsValidHours(double hours)
    {
        if (hours <= 100 && hours >= 1)
        {
            return true;
        }
        return false;
    }

    //Calculates the correct wage
    double CalcWage()
    {
        double wage;

        if (hours < 41)
        {
            wage = hours * rate;
        }
        else
        {
            wage = (40 * rate) + ((hours - 40) * 14.25);
        }

        return wage;
    }
}
