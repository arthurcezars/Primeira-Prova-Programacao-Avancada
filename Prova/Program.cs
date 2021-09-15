using System;
using Prova.Models;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Concessionaria ford = new Concessionaria("Serra", "Rodrigo", DateTime.Now.Year);

            Carro ecoSport = new Nacional("Prata", "ford", "não sei", 69000.00, DateTime.Now.Year);

            ford.AdicionarCarro(ecoSport);
        }
    }
}
