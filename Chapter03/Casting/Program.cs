using static System.Convert;

double a = 9.8;
int b = ToInt32(a);
int c = Convert.ToInt32(a);  // without import using static System.Convert;


double[] doublesArray = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };


foreach (double num in doublesArray)
{
    WriteLine($"Looping through array convert {num } to integer example: {ToInt32(num)}");
}