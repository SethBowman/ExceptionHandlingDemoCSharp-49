var numbers = new int[] { 1, 2, 3, 4, 5 };


//try-catch block

try
{
    //try to do something
    Console.WriteLine(numbers[5]);
}
catch (IndexOutOfRangeException e)
{
    //if we are thrown an exception, we catch it
    Console.WriteLine($"That was not an index that exists. {e.Message}");
}
catch (Exception e)
{
    //umbrella catch, catches all exceptions we may have missed
    Console.WriteLine(e.Message);
}


Console.WriteLine("Continue on..");


try
{
    Console.WriteLine("Please give me a number:");
    var userInput = int.Parse(Console.ReadLine());
    Console.WriteLine(userInput);

}
catch (FormatException e)
{
    Console.WriteLine($"Failed to parse. {e.Message}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
finally
{
    //optional
    //happens no matter what
    Console.WriteLine("Finally block");
}

Console.WriteLine("Continue on..");

var strNumbers = new string[] { "12", "2", "twelve", "ten", "thirty", "33", "four", "9" };
var realNumbers = new List<int>();

foreach (var strNumber in strNumbers)
{
    try
    {
        var parsedNumber = int.Parse(strNumber);
        realNumbers.Add(parsedNumber);
    }
    catch (FormatException e)
    {
        Console.WriteLine($"Could not parse {strNumber}. {e.Message}");
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

Console.WriteLine("Parsed numbers:");

foreach (var number in realNumbers)
{
    Console.WriteLine(number);
}