string?[] names;

names = new string[4];

names[0] = "Nix0";
names[1] = "Nix1";
names[2] = "Nix2";
names[3] = "Nix3";

//for (int i = 0; i < names.Length; i++)
//{
//    WriteLine(names[i]);
//}

string?[] names2 = new[] { names[0], names[1], names[2], names[3] };

for (int i = 0; i < names2.Length; i++)
{
    WriteLine(names2[i]);
}