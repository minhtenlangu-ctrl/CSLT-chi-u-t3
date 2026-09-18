using System;

/*class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    return;
            }

            Console.WriteLine("Result = " + result);
        }
    }*/

/*class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        char op = Convert.ToChar(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return;
                }
                break;

            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine("Result = " + result);
    }
}*/

/*class Program
{
    static void Main()
    {
        for (int y = -5; y <= 5; y++)
        {
            int x = y * y + 2 * y + 1;

            Console.WriteLine("y = " + y + ", x = " + x);
        }
    }
}*/

/*class Program
{
    static void Main()
    {
        Console.Write("Enter distance in kilometers: ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter hours: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter minutes: ");
        int minutes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter seconds: ");
        int seconds = Convert.ToInt32(Console.ReadLine());

        // Convert total time to hours
        double totalHours = hours + minutes / 60.0 + seconds / 3600.0;

        // Speed in km/h
        double speedKm = distance / totalHours;

        // Convert km/h to miles/h
        double speedMiles = speedKm * 0.621371;

        Console.WriteLine("Speed = " + speedKm + " km/h");
        Console.WriteLine("Speed = " + speedMiles + " miles/h");
    }
}*/

/*class Program
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double r = Convert.ToDouble(Console.ReadLine());

        double surface = 4 * Math.PI * r * r;
        double volume = (4.0 / 3.0) * Math.PI * r * r * r;

        Console.WriteLine("Surface area = " + surface);
        Console.WriteLine("Volume = " + volume);
    }
}*/

/*class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = Convert.ToChar(Console.ReadLine());

        if (char.IsDigit(ch))
        {
            Console.WriteLine("It is a digit.");
        }
        else if ("aeiouAEIOU".Contains(ch))
        {
            Console.WriteLine("It is a vowel.");
        }
        else
        {
Console.WriteLine("It is another symbol.");
        }
    }
}*/
