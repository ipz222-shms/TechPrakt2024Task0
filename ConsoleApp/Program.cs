Console.WriteLine("Welcome!\nLet's sum numbers.\n");

double EnterValue(string text)
{
    text += " (q to quit): ";
    Console.Write(text);
    
    double? result = null;
    do
    {
        var input = Console.ReadLine();
        if (input == "q")
            Environment.Exit(0);
        if (double.TryParse(input, out var res))
            result = res;
        else
            Console.Write("Can't process this value. Try again: ");
    } while (result is null);
    
    return (double)result;
}

while (true)
{
    double val1, val2, result;
    val1 = EnterValue("Enter first number");
    val2 = EnterValue("Enter second number");
    result = val1 + val2;
    Console.WriteLine($"Sum: {result}\n\n");
}
