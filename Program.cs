using ExceptionHandler;

/////// Lezione

Console.WriteLine("Handle the exception of indexes of this array { 1, 8, 12, 5 }: ");

Console.WriteLine("Please insert an index: ");
int index = Int32.Parse(Console.ReadLine());

int result = ExceptionManager.GetNumber(index);

if (ExceptionManager.WrongAnswer)
{
    Console.WriteLine("The index was wrong");
}
else
{
    Console.WriteLine($"The number is: {result}");
}


///////////////
//1.Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.

Console.WriteLine("Exercise 1) Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.: ");
Esercizio1 esercizio1 = new Esercizio1();


try
{
    Console.WriteLine("Enter the number which you want to devide: ");
    double n1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the number of devision: ");
    double n2 = Convert.ToDouble(Console.ReadLine());

    double risutlato = esercizio1.Calculate(n1, n2);
    if (Esercizio1.WrongNumber)
    {
        Console.WriteLine("Can not devide by 0");
    }
    else
    {
        Console.WriteLine($"result is: {risutlato}");

    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Non-numeric value entered.");
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
/////////////////
//2.Write a C# program to implement a method that takes an integer as input and throws an exception
//if the number is negative. Handle the exception in the calling code.


Console.WriteLine("Exercise 2) Write a C# program to implement a method that takes an integer as input and " +
    "throws an exception if the number is negative. Handle the exception in the calling code.: ");


try
{
    Console.WriteLine("Write a number: ");
    int number2 = Int32.Parse(Console.ReadLine());

    ControlPositiveNumber(number2);

    Console.WriteLine("Valid input: " + number2);
}
catch (NegativeException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

static void ControlPositiveNumber(int number)
{
    if (number < 0)
    {
        throw new NegativeException("Not Allowed");
    }
}

class NegativeException : Exception
{
    public NegativeException(string message) : base(message) { }
}
