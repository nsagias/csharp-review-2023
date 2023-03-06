int a = 3;
int b = a++;
int c = 3;
int d = ++c;

WriteLine($" a {a} b {b}");
WriteLine($" c {c} d {d}");


// Binary Arithmetic operators
int e = 11;
int f = 3;

WriteLine($"e is {e}, if is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");


// Double vs Whole numbers
double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}"); // whole numbers
WriteLine($"g / f = {g / f}"); // floating point


// Assignment Operators
int p = 6;
p += 3;
WriteLine(p);
p -= 3;
WriteLine(p);
p *= 3;
WriteLine(p);
p /= 3;
WriteLine(p);

ReadKey();