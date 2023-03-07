﻿string?[] names;

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

//for (int i = 0; i < names2.Length; i++)
//{
//    WriteLine(names2[i]);
//}


// Multi-Dimensional Arrays
string[,] grid1 = new[,] {
  { "A0", "B0", "C0", "D0" },
  { "A1", "B1", "C1", "D1" },
  { "A2", "B2", "C2", "D2" }
};

//WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
//WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");
//WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");
//WriteLine($"Upper bound of the second dimension is: {grid1.GetUpperBound(1)}");


// loop through multi-dimensional array
//for (int row = 0; row <= grid1.GetUpperBound(0); row++)
//{
//    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
//    {
//        WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
//    }
//}


// jagged multi-dimensional array
string[][] jagged = new[]
{
  new[] { "Alpha", "Beta", "Gamma" },
  new[] { "Anne", "Ben", "Charlie", "Doug" },
  new[] { "Aardvark", "Bear" }
};

// find upperbound
//WriteLine("Upper bound of array of arrays is: {0}",
//  jagged.GetUpperBound(0));
//for (int array = 0; array <= jagged.GetUpperBound(0); array++)
//{
//    WriteLine("Upper bound of array {0} is: {1}",
//      arg0: array,
//      arg1: jagged[array].GetUpperBound(0));
//}

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
    for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
    {
        WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
    }

}