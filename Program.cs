using System;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema de produtos!\n\nInsira, linha por linha, o nome do produto, seu preço e quantidade:");
            string nomeProduto = Console.ReadLine();
            double precoProduto = double.Parse(Console.ReadLine());
            int quantidade = int.Parse(Console.ReadLine());
            if (quantidade > 0 && precoProduto > 0)
            {
                Calculos p = new Calculos(nomeProduto, precoProduto, quantidade);
                Console.WriteLine($"Produto - {p.Nome};\nPreço total para {p.qnt} produto(s) - {p.CalcularPreco(p.preco, p.qnt)}");
            }
        }
    }
}