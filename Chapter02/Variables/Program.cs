using System.Xml;
using System.Text;
using Variables;
using System;

double heightInMeters = 1.88;
WriteLine($"The variable {nameof(heightInMeters)} has the number value {heightInMeters}");

// chars
// use single quotes
char letter = 'A';
WriteLine(letter);
char digit = '1';
WriteLine(digit);
char symbol = '$';
WriteLine(symbol);

//char userChoice =  GetSomeKeyStroke()// fake functions

// String
string firstName = "Nick";
WriteLine(firstName);
string lastName = "Sagias";
WriteLine(lastName);
string phoneNumber = "(123) 555-5555";
WriteLine(phoneNumber);

string horizontalLine = new('-', count: 74);
WriteLine(horizontalLine);

OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
WriteLine(grinningEmoji);

// Verbatim strings
string fullNameWithTab = "Nick\tSagias";
WriteLine(fullNameWithTab);

string filePath = @"C:\televisions\sony\bravia.txt";
WriteLine(filePath);


string xml = """
             <person age="50">
               <first_name>Mark</first_name>
             </person>
             """;
WriteLine(xml);


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

WriteLine(jsonExample);

// Specifc type of local variables
int? bingo; // int? indicates poossibley null
// WriteLine(bingo);
int population = 100_000_000;
WriteLine(population);

double weight = 110;
WriteLine(weight);

decimal price = 4.99M;
WriteLine(price);

string fruit = "Apples";
WriteLine(fruit);

char letterZ = 'Z'; // single quote
WriteLine(letterZ);

bool declareTrue = true;
WriteLine(declareTrue);



// Inferring the types

// WriteLine(bingo);
var population2 = 100_000_000;
WriteLine(population2);

var weight2 = 110;
WriteLine(weight2);

var price2 = 4.99M;
WriteLine(price2);

var fruit2 = "Apples";
WriteLine(fruit2);

var letter2 = 'Z'; // single quote
WriteLine(letter2);

var declareTrue2 = true;
WriteLine(declareTrue2);


// Creating new type objects
var xml1 = new XmlDocument();
WriteLine(xml1);

// using inference as below cannot tell type of doucment
//XmlDataDocument xml2 = new XmlDocument();

var file1 = File.CreateText("something11.text");
WriteLine(file1);

StreamWriter file2 = File.CreateText("something2.txt");
WriteLine(file2);

// latest targetd-typed new to instantiate
XmlDocument xml3 = new();
WriteLine(xml3);


Person nick = new ();

nick.TodaysDate = new(2023, 03, 05);

WriteLine(nick.TodaysDate);

List<Person> people = new()
{
    new() { FirstName = "Nick1", TodaysDate = DateTime.Today },
    new() { FirstName = "Nick2", TodaysDate = DateTime.Today },
    new() { FirstName = "Nick3", TodaysDate = DateTime.Today }
}; 

WriteLine(people[0].FirstName);
WriteLine(people[0].TodaysDate);


// Default values

WriteLine($"default(int) = {default(int)}");
WriteLine($"default(bool) = {default(bool)}");
WriteLine($"default(DateTime) = {default(DateTime)}");
WriteLine($"default(string) = {default(string)}");

int number = 13;
WriteLine($"number has been set to: {number}");
number = default;
WriteLine($"number has been reset to its default: {number}");


// format strings
// syntax: { index [, alignment ] [ : formatString ] }

string apples = "apples";
int applesCount = 1234;
string bananas = "bananas";
int bananasCount = 4567;

// syntax: { index [, alignment ] [ : formatString ] }
WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count"
);
// syntax: { index [, alignment ] [ : formatString ] }
WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: apples,
    arg1: applesCount
);

// syntax: { index [, alignment ] [ : formatString ] }
WriteLine(
      format: "{0,-10} {1,6:N0}",
     arg0: bananas,
     arg1: bananasCount
);

Write("Type your fist name and press ENTER/RETURN \n");
string? getFirstNameReadLine = ReadLine()!;
string? getNumberReadLine = ReadLine()!;
WriteLine($"Hello {getNumberReadLine} and the number you picked is {getNumberReadLine}");