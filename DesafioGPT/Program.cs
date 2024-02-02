using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DesafioGPT;
class Program
{
    static void Main(string[] args)
    {
        var carro = new Carro("Volks", "Gol", 2014, true);

        var moto = new Moto("Honda", "Biz", 2015, false);

        Console.WriteLine(carro.Info());
        Console.WriteLine(moto.Info());
    }
}

class Veiculo
{
    private string _marca;
    private string _modelo;
    private int _ano;

    public string Marca { get => _marca; set => _marca = value; }
    public string Modelo { get => _modelo; set => _modelo = value; }
    public int Ano { get => _ano; set => _ano = value; }

    public Veiculo(string marca, string modelo, int ano)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }

    public string Info()
    {
        return $" Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano} ";
    }
}

class Carro : Veiculo 
{
    private bool _aindaFabricada;
    public bool AindaFabricada { get => _aindaFabricada; set => _aindaFabricada = value; }

    public Carro(string marca, string modelo, int ano, bool aindaFabricada) : base(marca, modelo, ano)
    {
        AindaFabricada = aindaFabricada;
    }
}

class Moto : Veiculo
{
    private bool _automatica;
    public bool Automatica { get => _automatica; set => _automatica = value; }

    public Moto(string marca, string modelo , int ano, bool automatica) : base(marca, modelo, ano)
    {
        Automatica = automatica;
    }
}

