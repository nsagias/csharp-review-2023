// Print number of arugments passed
WriteLine($"There are {args.Length} arguments");

// Loop through arguments and print arguments passed
foreach (string arg in args)
{
    WriteLine(arg);
}



if (args.Length < 3)
{
    WriteLine("You must specify two colors and curser size");
    WriteLine("For example: dotnet run red yellow");
    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true
);

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true
);

CursorSize = int.Parse(args[2]);