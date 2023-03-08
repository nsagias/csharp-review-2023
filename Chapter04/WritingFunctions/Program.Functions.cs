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

}