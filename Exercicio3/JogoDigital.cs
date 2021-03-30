using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3
{
    class JogoDigital : Produto
    {
        //Atributos
        private string console;

        //Construtor
        public JogoDigital(string console, float preco, string titulo) : base(preco, titulo)
        {
            this.console = console;
            this.Preco = preco;
            this.Titulo = titulo;
        }

        //Encapsulamento
        public string Console_ { get => console; }

        //Metodos
        public override void InformarDescricao()
        {
            Console.WriteLine("Titulo: {0}, Console: {1}.", Titulo, Console_);

        }
    }
}
