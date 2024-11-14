using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgetoRestaurante.Entidades
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(int id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

    }
}
