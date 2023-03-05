using System.Text;

double heightInMeters = 1.88;
Console.WriteLine($"The variable {nameof(heightInMeters)} has the number value {heightInMeters}");

// chars
// use single quotes
char letter = 'A';
Console.WriteLine(letter);
char digit = '1';
Console.WriteLine(digit);
char symbol = '$';
Console.WriteLine(symbol);

//char userChoice =  GetSomeKeyStroke()// fake functions

// String
string firstName = "Nick";
Console.WriteLine(firstName);
string lastName = "Sagias";
Console.WriteLine(lastName);
string phoneNumber = "(123) 555-5555";
Console.WriteLine(phoneNumber);

string horizontalLine = new('-', count: 74);
Console.WriteLine(horizontalLine);

Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);

// Verbatim strings
string fullNameWithTab = "Nick\tSagias";
Console.WriteLine(fullNameWithTab);

string filePath = @"C:\televisions\sony\bravia.txt";
Console.WriteLine(filePath);


string xml = """
             <person age="50">
               <first_name>Mark</first_name>
             </person>
             """;
Console.WriteLine(xml);


// String interpolation with object
var personObject = new { FirstName = "Nick", ANumber = 10 };

// double dollar size neeed to interpolate with objects
string jsonExample = $$"""
    {
        "first_name": "{{personObject.FirstName}}",
        "age": {{personObject.ANumber}},
        ""calculation", "{{{1 + 2}}}"
    }
    """;

Console.WriteLine(jsonExample);