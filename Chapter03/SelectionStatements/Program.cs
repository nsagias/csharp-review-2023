using SelectionStatements;

// if else control flow
//string password = "ninja";

//if (password.Length < 8)
//{
//    WriteLine("Password is too short.  Should be atleast 8 charaters");
//}
//else
//{
//    WriteLine("Your password is strong");
//}

//// switch control flow
//int randomNumber = Random.Shared.Next(1, 7);
//WriteLine($"Random number generated {randomNumber}");
//switch (randomNumber)
//{
//    case 1:
//        WriteLine("One");
//        break;
//    case 2:
//        WriteLine("Two");
//        goto case 1;
//    case 3: // falls through
//    case 4:
//        WriteLine("Three or Four");
//        goto case 1;
//    case 5:
//        goto A_label;
//    default:
//        WriteLine("Default");
//        break;
//} // end of switch

//WriteLine("After end of switch");
//A_label:
//WriteLine($"After A_label");


Animal?[] animals = new Animal?[]
{
    new Cat
    {
        Name = "Nick1",
        TodaysDate = DateTime.Today,
        Legs = 4,
        IsDometic = true,
    },
    null,
    new Cat
    {
        Name = "Nick2",
        TodaysDate = new(year: 2022, month: 8, day: 23),
        Legs = 4,
        IsDometic = false,
    },
    new Spider
    {
        Name = "Nick3",
        TodaysDate = new(year: 2022, month: 8, day: 23),
        Legs = 8,
        IsPoisonous = true
    },
    new Spider
    {
        Name = "Nick4",
        TodaysDate = new(year: 2023, month: 1, day: 23),
        Legs = 8,
        IsPoisonous = false
    },

};

foreach (Animal? animal in animals)
{
    // initialize varible
    string? message;
    switch (animal)
    {
        case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
            message = $"The cat named {fourLeggedCat.Name} has four legs.";
            break;
        case Cat wildCat when wildCat.IsDometic == false:
            message = $"The cat named {wildCat.Name} is wild.";
            break;
        case Cat cat:
            message = $"The cat is named {cat.Name}.";
            break;
        default: // default is always evaluated last
            message = $"The animal named {animal?.Name} is a {animal?.GetType().
            Name}.";
            break;
        case Spider spider when spider.IsPoisonous:
            message = $"The spider names {spider.Name} is poisoness";
            break;
        case null:
            message = "This animal is null";
            break;
    }
    WriteLine($"This is the message {message}");
}