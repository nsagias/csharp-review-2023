using static System.Convert;

double a = 9.8;
int b = ToInt32(a);
int c = Convert.ToInt32(a);  // without import using static System.Convert;


double[] doublesArray = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };


foreach (double num in doublesArray)
{
    WriteLine($"Looping through array convert {num } to integer example: {ToInt32(num)}");
}

WriteLine("---");
WriteLine("Converting any type to string");
int num2 = 12;
bool booleanValue = true;
DateTime timeNow = DateTime.Now;
object myObj = new();
WriteLine(num2);
WriteLine(booleanValue);
WriteLine(timeNow);
WriteLine(myObj);


WriteLine("---");
WriteLine("Converting binary type to string");
byte[] binaryObject = new byte[128];

Random.Shared.NextBytes(binaryObject);
WriteLine(binaryObject);
WriteLine("loop through binary object as bites");

for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X} ");
}

WriteLine();
string encoded = ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");


// parsing
WriteLine();
WriteLine("---Parsing");

int age = int.Parse("27");
WriteLine(age);
DateTime aDate = DateTime.Parse("1 January 2023");
WriteLine(aDate); // 1/1/2023 12:00:00 AM
WriteLine($"{ aDate:D}");  // Sunday, January 1, 2023


// TryParse
WriteLine();
WriteLine("---TryParse");
//int count1 = int.Parse("ABC");  //  System.FormatException: The input string 'ABC' was not in a correct format.

WriteLine("Type a number");
string? input = ReadLine();
if (int.TryParse(input, out int count))
{
    WriteLine($"The number is {count}");
}
else
{
    WriteLine("Could not parse input");
}