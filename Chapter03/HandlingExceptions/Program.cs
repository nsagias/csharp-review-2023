﻿WriteLine("Before parsing");
Write("Enter a number: ");
string? input = ReadLine();
try
{
    int? numInput = int.Parse(s: input);
    WriteLine($"The number selected is {numInput}");
}
catch (FormatException)
{
    WriteLine($"The number you enter is not valid example");
}
catch (OverflowException)
{
    WriteLine("Your number type does not fit the INT type, this is a OverflowException");
}
catch (Exception error)
{
    WriteLine($"Exception Type: {error.GetType()}");
    WriteLine($"Exception Message: {error.Message}");
}
WriteLine("After parsing");