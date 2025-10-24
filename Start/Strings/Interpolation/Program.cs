// Application Programming .NET Programming with C# by Abdullahi Tijjani

// String Interpolation is a feature that enables the easy insertion of data
// and expression values into a string variable

int a = 100;
float b = 250.0f;
string c = "CSharp";

// String output the old way - using placeholders
Console.WriteLine("The values are {0}, {1} and {2}", a, b, c);

// TODO: Using string interpolation, the code is much easier to read
Console.WriteLine("{0,-15} {1,10}", "Float Val", "Int Val"); 
Console.WriteLine("{0,-15} {1,10}", f1, i1);

// TODO: Interpolated strings can contain expressions as well
Console.WriteLine("{0,-15} {1,10}", "Float Val", "Int Val"); 
Console.WriteLine("{0,-15} {1,10}", f1, i1);

// TODO: Complex objects can be embedded in strings this way as well
Console.WriteLine("{0,-15} {1,10}", "Float Val", "Int Val"); 
Console.WriteLine("{0,-15} {1,10}", f1, i1);
