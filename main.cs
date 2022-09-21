using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Kalkulator Sederhana");
        Console.WriteLine("Press 1 for addition");
        Console.WriteLine("Press 2 for subtraction");
        Console.WriteLine("Press 3 for multiplication");
        Console.WriteLine("Press 4 for division");
        Console.WriteLine("Enter the action to be performed!");


        int actionType = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter the first number");
        double firstNumberInput = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        double secondNumberInput = Convert.ToDouble(Console.ReadLine());

        double result;

        switch (actionType)
        {
            case 1:
                result = firstNumberInput + secondNumberInput;
                break;
            case 2:
                result = firstNumberInput - secondNumberInput;

                break;
            case 3:
                result = firstNumberInput * secondNumberInput;
                break;
            case 4:
                result = firstNumberInput / secondNumberInput;
                break;
            default:
                Console.WriteLine($"Unrecognized calculation type");
                result = 0;
                break;
        }

        Console.WriteLine($"The result is {result}");




    }


}