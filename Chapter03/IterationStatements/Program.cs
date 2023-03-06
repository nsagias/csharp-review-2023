// do while
string? password;
do
{
    Write("Enter your password: ");
    password = ReadLine();
}
while (password != "pwd");
WriteLine("Correct!");


// for statement
for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

// foreach statement
string[] names = { "Nick1", "Nick2", "Nick3" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} character in it");
}