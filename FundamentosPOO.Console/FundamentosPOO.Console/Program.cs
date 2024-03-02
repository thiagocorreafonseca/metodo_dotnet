// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

var funcionario = new Funcionario();
funcionario.Nome = "Teste";
funcionario.Profissao = "Profissao";
funcionario.Telefone = "1234";
funcionario.Salario = 15000;

funcionario.Apresentar();

public class Pessoa
{
    public Pessoa() { }

    public Pessoa(string nome, string profissao, string telefone)
    {
        Nome = nome;
        Profissao = profissao;
        Telefone = telefone;
    }

    public string Nome { get; set; }
    public string Profissao { get; set; }
    public string Telefone { get; set; }

    public void Apresentar()
    {
        Console.WriteLine(FormatarMensagem());
    }

    private string FormatarMensagem()
    {
        return $"{Nome}, {Profissao}, {Telefone}";
    }
}

public class Funcionario: Pessoa
{
    public Funcionario() { }
    public Funcionario(string nome, string profissao, string telefone, int salario) : base(nome, profissao, telefone)
    {
        Salario = salario;
    }
    public double Salario { get; set; }
}