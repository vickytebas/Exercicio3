using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Livro: Produto
    {
        //Atributos
        private string autor;

        //Construtor
        public Livro(string autor, float preco, string titulo) : base(preco, titulo)
        {
            this.autor = autor;
            this.Titulo = titulo;
            this.Preco = preco;
        }

        //Encapsulamento
        public string Autor { get => autor; }

        //Metodos
        public override void InformarDescricao()
        {
            Console.WriteLine("Titulo: {0}, Autor: {1}.", Titulo, Autor);
        }
    }
}
