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

ReadKey();