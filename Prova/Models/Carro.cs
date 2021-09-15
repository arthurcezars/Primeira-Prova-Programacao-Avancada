using System;

namespace Prova.Models
{
    public abstract class Carro
    {
        public string Cor { get; protected set; }
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public double Valor { get; protected set; }  
        public int AnoFabricacao { get; protected set; }
        public bool RevisaoEmDia { get; protected set; }

        public Carro(string cor, string marca, string modelo, double valor, int anoFabricacao)
        {
            Cor = cor;
            Marca = marca;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            RevisaoEmDia = true;

            DefinirValorVeiculo(valor);
        }

        public virtual void DefinirValorVeiculo(double custoFixo)
        {
            throw new NotImplementedException("Esse método não foi implementado!");
        }

        // Alterar o estado que diz se foi feita revisão no veiculo.
        public void Revisao(bool emDia)
        {
            RevisaoEmDia = emDia;
        }

        // Caso após a revisão for constado que o valor de mercado do carro mudou, é passado o novo valor.
        public void Revisao(bool emDia, double novoValor)
        {
            RevisaoEmDia = emDia;
            DefinirValorVeiculo(novoValor);
        }
    }
}