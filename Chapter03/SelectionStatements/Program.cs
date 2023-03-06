// if else control flow
string password = "ninja";

if (password.Length < 8)
{
    WriteLine("Password is too short.  Should be atleast 8 charaters");
}
else
{
    WriteLine("Your password is strong");
}

// switch control flow
int randomNumber = Random.Shared.Next(1, 7);
WriteLine($"Random number generated {randomNumber}");
switch (randomNumber)
{
    case 1:
        WriteLine("One");
        break;
    case 2:
        WriteLine("Two");
        goto case 1;
    case 3: // falls through
    case 4:
        WriteLine("Three or Four");
        goto case 1;
    case 5:
        goto A_label;
    default:
        WriteLine("Default");
        break;
} // end of switch

WriteLine("After end of switch");
A_label:
WriteLine($"After A_label");
