using System;
using BooleanOperators;

bool a = true;
bool b = false;

WriteLine($"AND | a | b ");
WriteLine($"a   | {a & a} | {a & b}");
WriteLine($"b   | {b & a} | {b & b}");
WriteLine($"---");

WriteLine($"OR");
WriteLine($"a   | {a | a} | {a | b}");
WriteLine($"b   | {b | a} | {b | b}");
WriteLine($"---");

WriteLine($"XOR");
WriteLine($"a   | {a ^ a} | {a ^ b}");
WriteLine($"b   | {b ^ a} | {b ^ b}");


// Condtional Logical Opertors
WriteLine("---");
WriteLine($"a & DoStuff() = {a & Functions1.DoStuff()}");
WriteLine($"b & DoStuff() = {b & Functions1.DoStuff()}");


WriteLine("---");
WriteLine($"a && DoStuff() = {a && Functions1.DoStuff()}");
WriteLine($"b && DoStuff() = {b && Functions1.DoStuff()}");
ReadKey();