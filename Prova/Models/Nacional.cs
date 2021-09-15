using System;

namespace Prova.Models
{
    public class Nacional : Carro
    {
        public Nacional(string cor, string marca, string modelo, double valor, int anoFabricacao)
            :   base(cor, marca, modelo, valor, anoFabricacao)
        {}

        public override void DefinirValorVeiculo(double custoFixo)
        {
            if (custoFixo > 0)
            {
                Valor = (custoFixo * 1.5) + (custoFixo * 0.2) + (custoFixo / 10);
            }
            else
            {
                Console.WriteLine("O valor passado deve ser maior que 0!");
            }
        }
    }
}