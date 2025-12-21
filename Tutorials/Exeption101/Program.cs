/*
    Update the Process1 method to catch the exception that's thrown in the WriteMessage method.
    The Process1 method should print the following message to console when the exception is caught:
    "Exception caught in Process1"

    Don't change any code outside the Process1 method.

    When you run your updated application, it should generate the following output:
    "∞
    Exception caught in Process1
    Exit program"

*/

try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
        WriteMessage();
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    try
    {
        Console.WriteLine(float1 / float2);
        Console.WriteLine(number1 / number2);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }
    checked
{
    try
    {
        smallNumber = (byte)number1;
    }
    catch (OverflowException ex)
    {
        Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
    }  
}
}