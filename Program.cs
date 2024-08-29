using System;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao sistema de produtos!\n\nInsira, linha por linha, o nome do produto, seu preço e quantidade:");
            string nome = Console.ReadLine();
            double preco = double.Parse(Console.ReadLine());
            int qnt = int.Parse(Console.ReadLine());
            if (qnt > 0 && preco > 0)
            {
                Calculos p = new Calculos(nome, preco, qnt);
                Console.WriteLine($"Produto - {p.nome};\nPreço total para {p.qnt} produto(s) - {p.CalcularPreco(preco, qnt)}");
            }
        }
    }
}