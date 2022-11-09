
using ConsoleUI;

try
{
    int number = Divide(10, 0);

}
catch (DivideByZeroException)
{
    Console.WriteLine("You cannot divide by zero");
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally block");
}

int[] array = new int[] { 1, 2, 3, 4 };
for (int i = 0; i <= 4; i++)
{
    try
    {
        Console.WriteLine(array[i]);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An exception occured in our program");
        Console.WriteLine(ex.Message);
    }

}


// use conditional compilation symbol
#if DEBUG
Console.WriteLine("Debug mode");
#endif
Console.WriteLine("Release mode");

try
{
    CheckSomething("");
}
catch (APIException)
{
    // Handle exception
    Console.WriteLine("Use another url");
}
catch (Exception ex)
{
    // Handle exception
    Console.WriteLine("An exception occured in our program");
    Console.WriteLine(ex.Message);
}

static void CheckSomething(string url)
{
    if (url.Length == 0)
    {
        throw new APIException();
    }
}


static int Divide(int a, int b)
{
    if (b == 0)
    {
        throw new DivideByZeroException();
    }
    return a / b;
}

Console.ReadLine();


