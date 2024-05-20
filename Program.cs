using ExceptionHandler;

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

Console.WriteLine("please prss a key to exit");
Console.ReadLine();