using System;

namespace Prova.Models
{
    public class Importado : Carro
    {
        public Importado(string cor, string marca, string modelo, double valor, int anoFabricacao)
            :   base(cor, marca, modelo, valor, anoFabricacao)
        {}

        public override void DefinirValorVeiculo(double custoFixo)
        {
            if (custoFixo > 0)
            {
                Valor = (custoFixo * 3.0) + (custoFixo * 0.6) + (custoFixo / 5);
            }

            Console.WriteLine("O valor passado deve ser maior que 0!");
        }
    }
}