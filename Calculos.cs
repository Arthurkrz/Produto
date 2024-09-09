using System;
using System.Collections.Generic;
using System.Text;

namespace Produto
{
    class Calculos
    {
        private string _nome;
        public double Preco { get; set; }
        public int Qnt { get; set; }
        public string Nome
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_nome))
                {
                    return "N/A";
                }
                return _nome;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(_nome))
                {
                    _nome = value;
                }
                else
                {
                    _nome = "N/A";
                }
            }
        }
        public Calculos(string nomeProduto, double precoProduto, int quantidade)
        {
            Nome = nomeProduto;
            Preco = precoProduto;
            Qnt = quantidade;
        }
        public double CalcularPreco(double preco, int qnt)
        {
            if (qnt < 10)
            {
                return preco * qnt;
            }
            else if (qnt > 10 && qnt < 21)
            {
                return (preco - (preco * 0.1)) * qnt;
            }
            else if (qnt > 20 && qnt < 51)
            {
                return (preco - (preco * 0.2)) * qnt;
            }
            else
            {
                return (preco - (preco * 0.25)) * qnt;
            }
        }
    }
}