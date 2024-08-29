using System;
using System.Collections.Generic;
using System.Text;

namespace Produto
{
    class Calculos
    {
        public string nome;
        public double preco;
        public int qnt;
        public double CalcularPreco(double preco, int qnt)
        {
            if (qnt < 10)
            {
                return preco;
            }
            else if (qnt > 10 && qnt < 21)
            {
                return preco - (preco * 0.1);
            }
            else if (qnt > 20 && qnt < 51)
            {
                return preco - (preco * 0.2);
            }
            else
            {
                return preco - (preco * 0.25);
            }
        }
        public Calculos(string nomeProduto, double precoProduto, int quantidade)
        {
            nome = nomeProduto;
            preco = precoProduto;
            qnt = quantidade;
        }
    }
}