using CallStackExceptionHandlingLib;
using static System.Console;
WriteLine("IN MAIN CallStackExceptionHandling");
Alpha();
void Alpha()
{
    WriteLine("In ALPHA");
    Beta();
}
void Beta()
{
    WriteLine("In BETA");
    try
    {
        Calculator.Gamma();

    }
    catch (Exception ex)
    {
        WriteLine($"Exceptioon: {ex.Message}");
        throw;
    }
}