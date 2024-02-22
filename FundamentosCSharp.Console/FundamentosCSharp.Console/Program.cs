// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var nome = Console.ReadLine();

Console.WriteLine(nome);

double valorDouble = 3.14;
float valorFloat = 3.14F;
decimal valorDecimal = 3.14M;

int valorInteiro = 100;
bool valorBoolean = true;
char valorChar = 'A';
string valorString = "Thiago";

const double PI = 3.1415;

Console.WriteLine($"Double: {valorDouble}");
Console.WriteLine($"Float: {valorFloat}");
Console.WriteLine($"Int: {valorInteiro}");
Console.WriteLine($"Decimal: {valorDecimal}");
Console.WriteLine($"---------");
Console.WriteLine($"Boolean: {valorBoolean}");
Console.WriteLine($"Char: {valorChar}");
Console.WriteLine($"String: {valorString}");
Console.WriteLine($"---------");
Console.WriteLine($"CONST: {PI}");

