double heightInMeters = 1.88;
Console.WriteLine($"The variable {nameof(heightInMeters)} has the number value {heightInMeters}");

// chars
// use single quotes
char letter = 'A';
char digit = '1';
char symbol = '$';
//char userChoice =  GetSomeKeyStroke()// fake functions

// String
string firstName = "Nick";
string lastName = "Sagias";
string phoneNumber = "(123) 555-5555";
string horizontalLine = new('-', count: 74);

Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);