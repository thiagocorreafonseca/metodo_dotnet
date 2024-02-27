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

Console.WriteLine("");
Console.WriteLine($"---------");

#region Operadores Comparacao
var p = 5;
var q = 10;

bool maior = p > q;
bool menor = p < q;
bool maiorOuIgual = p >= q;
bool menorOuIgual = p <= q;
bool igual = p == q;
bool diferente = p != q;

Console.WriteLine($"P:{p} | Q:{q}");
Console.WriteLine($"Maior: {maior}");
Console.WriteLine($"Menor: {menor}");
Console.WriteLine($"Maior Ou Igual: {maiorOuIgual}");
Console.WriteLine($"Menor Ou Igual: {menorOuIgual}");
Console.WriteLine($"Igual: {igual}");
Console.WriteLine($"Diferente: {diferente}");
#endregion

Console.WriteLine("");
Console.WriteLine($"---------");

#region Operadores Logicos
bool x = true;
bool y = false;

var and = x && y; //AND
var or = x || y; //OR
var notX = !x; //NOT
var notY = !y; //NOT

Console.WriteLine($"X:{x} | Y:{y}");
Console.WriteLine($"And: {and}");
Console.WriteLine($"Or: {or}");
Console.WriteLine($"NotX: {notX}");
Console.WriteLine($"NotY: {notY}");
#endregion

Console.WriteLine("");
Console.WriteLine($"---------");

#region Operadores de Igualdade e Atribuicao
int k = 5;
k = 10;
Console.WriteLine($"K: {k}");

k += 5;
Console.WriteLine($"K += 5: {k}");
k -= 3;
Console.WriteLine($"K -= 3: {k}");
k *= 2;
Console.WriteLine($"K *= 2: {k}");
k /= 4;
Console.WriteLine($"K /= 4: {k}");
k %= 5;
Console.WriteLine($"K %= 5: {k}");
#endregion

#region Estruturas de Condicao IF_ELSE
var nota = 75;

if (nota >= 70)
{
    Console.WriteLine("Aprovado.");
}
else if(nota >= 30)
{
    Console.WriteLine("Recuperação.");
}
else
{
    Console.WriteLine("Reprovado.");
}
#endregion

#region Estruturas de Condicao - SWITCH_CASE
var opcao = 2;

switch (opcao)
{
    case 1:
        Console.WriteLine("Opcao 1");
        break;

    case 2:
        Console.WriteLine("Opcao 2");
        break;

    case 3:
        Console.WriteLine("Opcao 3");
        break;

    default:
        Console.WriteLine("Opcao DESCONHECIDA");
        break;
}

switch (nota)
{
    case int n when (n >= 70):
        Console.WriteLine("Aprovado");
        break;

    case int n when (n <= 30):
        Console.WriteLine("Reprovado");
        break;

    default:
        break;
}

string textoNumero = opcao switch
{
    1 => "UM",
    2 => "DOIS",
    3 => "TRES",
    _ => "DESCONHECIDO"

};

Console.WriteLine(textoNumero);
#endregion

#region Matrizes
int[] matriz = { 1, 2, 3, 4, 5, 6 };
int[] matrizVazia = new int[5];

var tamanhoMatriz = matriz.Length;
var dimensaoMatriz = matriz.Rank;

Console.WriteLine($"Tamanho Matriz: {tamanhoMatriz}");
Console.WriteLine($"Dimensao Matriz: {dimensaoMatriz}");

Array.Sort(matriz);
Array.Reverse(matriz);

Console.ReadLine();

#endregion