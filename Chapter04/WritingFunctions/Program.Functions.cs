partial class Program
{
    /// <summary>
    /// Prints time table for one number and its range
    /// </summary>
    /// <param name="number"></param>
    /// <param name="size"></param>
    static void TimeTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times-table with {size} rows: ");
        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} X {number} = {row * number}");
        }
        WriteLine();
    }

    /// <summary>
    /// Calculate take based on country code
    /// </summary>
    /// <param name="amount"></param>
    /// <param name="twoLetterRegionCode"></param>
    /// <returns>total tax for amount provided</returns>
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

    static int FibImperative(int num)
    {
        if (num == 1)
        {
            return 0;
        }
        else if (num == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(num - 1) + FibImperative(num - 2);
        }
    }

    static void RunFibImperative()
    {
        //for (int i = 1; i <= 30; i++)
        //{
        //    WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
        //      arg0: CardinalToOrdinal(i),
        //      arg1: FibImperative(num: i));
        //}
        for (int i = 1; i <= 30; i++)
        {
            WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibImperative(num: i):N0}.");
        }
    }

    static int FibFunctional(int num) => num switch
    {
        1 => 0,
        2 => 1,
        _ => FibFunctional(num - 1) + FibFunctional(num - 2)
    };

    static void RunFibFunctional()
    {
        for (int i = 1; i <= 30; i++)
        {
            WriteLine($"The {CardinalToOrdinal(i)} term of the Fibonacci sequence is {FibFunctional(num: i):N0}. functional");
        }
    }

}