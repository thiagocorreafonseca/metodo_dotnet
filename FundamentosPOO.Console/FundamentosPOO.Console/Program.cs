// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

var pessoa = new Pessoa();
pessoa.Nome = "Pessoa";
pessoa.Profissao = "profissao";
pessoa.Telefone = "02902304";

var funcionario = new Funcionario();
funcionario.Nome = "Teste";
funcionario.Profissao = "Profissao";
funcionario.Telefone = "1234";
funcionario.Salario = 15000;

funcionario.Apresentar();
funcionario.Apresentar("Fulano");

Pessoa[] pessoas = {pessoa, funcionario};

foreach (var p in pessoas)
{
    p.Apresentar();
}

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

    public virtual void Apresentar()
    {
        Console.WriteLine(FormatarMensagem());
    }

    public void Apresentar(string nome)
    {
        Console.WriteLine($"Olá, {nome}: {FormatarMensagem()}");
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

    public override void Apresentar()
    {
        base.Apresentar();
        Console.WriteLine($"Salário: {Salario}");
    }
}