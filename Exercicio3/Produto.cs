using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class Produto
    {
       
        //Construtor
        public Produto(float preco, string titulo)
        {
            this.Preco = preco;
            this.Titulo = titulo;
        }

        //Encapsulamento
        public string Titulo { get; protected set; }
        public float Preco { get; protected set; }

        //Metodos
        public virtual void InformarDescricao()
        {
            Console.WriteLine("Item da loja");
        }

        public virtual void InformarPreco()
        {
            Console.WriteLine("Preco: {0}", Preco);
        }
    }
}
