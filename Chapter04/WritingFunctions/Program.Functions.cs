partial class Program
{
    static void TimeTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times-table with {size} rows: ");
        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} X {number} = {row * number}");
        }
        WriteLine();
    }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        // declare variable
        decimal rate = 0.0M;
        switch (twoLetterRegionCode)
        {
            case "CH":
                rate = 0.08M;
                break;
            case "DK":
            case "NO":
                rate = 0.25m;
                break;
            case "GB":
            case "FR":
                rate = 0.2M;
                break;
            case "HU":
                rate = 0.27M;
                break;
            case "OR":
            case "AK":
            case "MT":
                rate = 0.0M;
                break;
            case "ND":
            case "WI":
            case "ME":
            case "VA":
                rate = 0.5M;
                break;
            case "CA":
                rate = 0.0825M;
                break;
            default:
                rate = 0.06M;
                break;

        }
        return amount * rate;
    }

    static string CardinalToOrdinal(int number)
    {
        int lastTwoDigits = number % 100;
        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                int lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };

                return $"{number:N0}{suffix}";
        }
    }

    static void ProcessCardinalToOrdinal(int numberRange)
    {
        for (int number = 1; number <= numberRange; number++)
        {
            WriteLine($"{CardinalToOrdinal(number)}");
        }
    }

    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(message:
              $"Non-negative integers for factiorial: {number}",
              paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number - 1);
            }
        }
    }

    static void RunFactorial(int num = 15)
    {
        for (int i = -2; i <= num; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is larger than a 32 bit integer ");
            }
            catch (Exception ex)
            {
                WriteLine($"{i}! Factorials create is {ex.GetType()} and message is {ex.Message}");
            }
        }
    }

}