using System.Xml;
using System.Text;
using Variables;
using System;

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

// Specifc type of local variables
int? bingo; // int? indicates poossibley null
// Console.WriteLine(bingo);
int population = 100_000_000;
Console.WriteLine(population);

double weight = 110;
Console.WriteLine(weight);

decimal price = 4.99M;
Console.WriteLine(price);

string fruit = "Apples";
Console.WriteLine(fruit);

char letterZ = 'Z'; // single quote
Console.WriteLine(letterZ);

bool declareTrue = true;
Console.WriteLine(declareTrue);



// Inferring the types

// Console.WriteLine(bingo);
var population2 = 100_000_000;
Console.WriteLine(population2);

var weight2 = 110;
Console.WriteLine(weight2);

var price2 = 4.99M;
Console.WriteLine(price2);

var fruit2 = "Apples";
Console.WriteLine(fruit2);

var letter2 = 'Z'; // single quote
Console.WriteLine(letter2);

var declareTrue2 = true;
Console.WriteLine(declareTrue2);


// Creating new type objects
var xml1 = new XmlDocument();
Console.WriteLine(xml1);

// using inference as below cannot tell type of doucment
//XmlDataDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something11.text");
Console.WriteLine(file1);

StreamWriter file2 = File.CreateText("something2.txt");
Console.WriteLine(file2);

// latest targetd-typed new to instantiate
XmlDocument xml3 = new();
Console.WriteLine(xml3);


Person nick = new ();

nick.TodaysDate = new(2023, 03, 05);

Console.WriteLine(nick.TodaysDate);

List<Person> people = new()
{
    new() { FirstName = "Nick1", TodaysDate = DateTime.Today },
    new() { FirstName = "Nick2", TodaysDate = DateTime.Today },
    new() { FirstName = "Nick3", TodaysDate = DateTime.Today }
}; 

Console.WriteLine(people[0].FirstName);
Console.WriteLine(people[0].TodaysDate);


// Default values

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default: {number}");


// format strings
// syntax: { index [, alignment ] [ : formatString ] }

string apples = "apples";
int applesCount = 1234;
string bananas = "bananas";
int bananasCount = 4567;

// syntax: { index [, alignment ] [ : formatString ] }
Console.WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count"
);
// syntax: { index [, alignment ] [ : formatString ] }
Console.WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: apples,
    arg1: applesCount
);

// syntax: { index [, alignment ] [ : formatString ] }
Console.WriteLine(
      format: "{0,-10} {1,6:N0}",
     arg0: bananas,
     arg1: bananasCount
);

Console.Write("Type your fist name and press ENTER/RETURN \n");
string? getFirstNameReadLine = Console.ReadLine()!;
string? getNumberReadLine = Console.ReadLine()!;
Console.WriteLine($"Hello {getNumberReadLine} and the number you picked is {getNumberReadLine}");