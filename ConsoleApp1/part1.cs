//------------------------------------------------------------------------------------------------------------------------------------------
// HELLO WORLD

// adds append after line Console.WriteLine("This is the first line");
// doesn´t add append Console.Write("This is the second line");

//------------------------------------------------------------------------------------------------------------------------------------------

// LITERALS

// single character = Console.WriteLine('b');
// integer = Console.WriteLine(123);
// float Console.WriteLine(0.25F);
// double literal Console.WriteLine(2.25432);
// decimal type literal Console.WriteLine(12.39816m);
// Console.WriteLine(true);
// Console.WriteLine(false);

//------------------------------------------------------------------------------------------------------------------------------------------

// VARIABLES

// Variable names are case-sensitive
// Examples:
// string firstName;
// char userOption;
// int gameScore;
// decimal particlesPerMillion;
// bool processedCustomer;

//string firstName;
//firstName = "Tomás";
//Console.WriteLine(firstName);

// The var keyword tells the C# compiler that the data type is implied by the assigned value

var nombre = "Tomás";
var mensajes = 3;
var temp = 34.4;

Console.WriteLine("Hello, " + nombre + "! You have " + mensajes + " messages in your inbox. The temperature is " + temp + " celsius.");

//------------------------------------------------------------------------------------------------------------------------------------------

// STRING FORMATTING

// \n to add a new line, \t to add a new tab
// use \\ for a single backlash to a filepath

//Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
//Console.WriteLine("Invoice: 1021\t\tComplete!");
//Console.WriteLine("Invoice: 1022\t\tComplete!");
//Console.WriteLine("\nOutput Directory:\t");
//Console.WriteLine(@"c:\invoices");
// Kon'nichiwa World
//Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
//Console.WriteLine(@"c:\invoices\app.exe -j");

// Use the @ directive to create a verbatim string literal that keeps all whitespace formatting and backslash characters in a string.
// Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
// Unicode characters may not print correctly depending on the application.

var saludo = "Wena";
string lawea = $"{saludo} {nombre}!";

int version = 11;
string updateText = "Update to Windows";

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English output: \n \t c:\\Exercise\\"+projectName+"\\data.txt");
Console.WriteLine("View English output: \n \t c:\\Exercise\\"+russianMessage+"\\data.txt");

// IMPORTANT! The $ symbol denotes an interpolated string and the value in the curly braces is displayed.

//------------------------------------------------------------------------------------------------------------------------------------------


// Parentheses (whatever is inside the parenthesis is performed first)
// Exponents
// Multiplication and Division (from left to right)
// Addition and Subtraction (from left to right)
