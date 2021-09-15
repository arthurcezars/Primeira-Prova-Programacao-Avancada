using System;
using System.Collections.Generic;

namespace Prova.Models
{
    public class Concessionaria
    {
        private string _localizacao;
        private string _gerentePrincipal;
        public int AnoFundacao { get; }
        private List<Carro> carrosDisponiveis;

        public Concessionaria(string localizacao, string gerente, int ano)
        {
            SetLocalizacao(localizacao);
            SetGerentePrincipal(gerente);
            AnoFundacao = ano;
            carrosDisponiveis = new List<Carro>();
        }

        public string GetLocalizacao()
        {
            return _localizacao;
        }

        public void SetLocalizacao(string localizacao)
        {
            _localizacao = localizacao;
        }

        public string GetGerentePrincipal()
        {
            return _gerentePrincipal;
        }

        public void SetGerentePrincipal(string gerente)
        {
            _gerentePrincipal = gerente;
        }

        public void AdicionarCarro(Carro carroNovo)
        {
            carrosDisponiveis.Add(carroNovo);
        }

        public double CalcularPortifolio()
        {
            double valorTotal = 0.0;

            foreach (Carro carro in carrosDisponiveis)
            {
                valorTotal += carro.Valor;
            }

            return valorTotal;
        }
    }
}