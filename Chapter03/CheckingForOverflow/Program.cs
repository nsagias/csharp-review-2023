try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        x++;
        WriteLine($"Increment +1: {x}");
        x++;
        WriteLine($"Increment +1: {x}");
        x++;
        WriteLine($"Increment +1: {x}");
        x++;
    }
}
catch (OverflowException)
{
    WriteLine("Catching overflow exception");
}



unchecked
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
    y--;
    WriteLine($"After decrementing: {y}");
}
