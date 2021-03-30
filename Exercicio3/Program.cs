using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto livroCaio = new Livro("Caio Boudens", 69.69f, "Como conquistar gatinhas online");
            Produto jogoRafael = new JogoDigital("Mobile", 0.00f, "UREK");
            Produto livroThiago = new Livro("Thiago Warton", 59.99f, "As cronicas de Douglas");

            Produto[] produtos = { livroCaio, jogoRafael, livroThiago };
            
            foreach (Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
