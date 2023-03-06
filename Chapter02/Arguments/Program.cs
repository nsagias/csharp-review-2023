// Print number of arugments passed
WriteLine($"There are {args.Length} arguments");

// Loop through arguments and print arguments passed
foreach (string arg in args)
{
    WriteLine(arg);
}






if (OperatingSystem.IsWindows())
{
    // execute code that only works on Windows
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
}
else if (OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    // execute code that only works on Windows 10 or later
}
else if (OperatingSystem.IsIOSVersionAtLeast(major: 14, minor: 5))
{
    // execute code that only works on iOS 14.5 or later

    WriteLine("Your code won't rung");
}
else if (OperatingSystem.IsBrowser())
{
    // execute code that only works in the browser with Blazor
}