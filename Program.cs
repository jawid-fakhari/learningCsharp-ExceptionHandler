using ExceptionHandler;

///////// Lezione

//Console.WriteLine("Please insert an index: ");
//int index = Int32.Parse(Console.ReadLine());

//int result = ExceptionManager.GetNumber(index);

//if (ExceptionManager.WrongAnswer)
//{
//    Console.WriteLine("The index was wrong");
//}
//else
//{
//    Console.WriteLine($"The number is: {result}");
//}

//Console.WriteLine("please prss a key to exit");
//Console.ReadLine();

//1.Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.
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

