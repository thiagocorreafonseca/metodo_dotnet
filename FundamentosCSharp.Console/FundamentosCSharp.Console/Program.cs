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

Console.WriteLine("");
Console.WriteLine($"---------");

#region Tipos e Variaveis
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
#endregion

Console.WriteLine("");
Console.WriteLine($"---------");

#region Operadores Aritmeticos
int a = 10;
int b = 20;

int soma = a + b;
int subtracao = a - b;
int multiplicacao = a * b;
int divisao = b / a;
int modulo = a % b;

Console.WriteLine($"Soma: {soma}");
Console.WriteLine($"Subtracao: {subtracao}");
Console.WriteLine($"Multiplicacao: {multiplicacao}");
Console.WriteLine($"Divisao: {divisao}");
Console.WriteLine($"Modulo: {modulo}");
#endregion

