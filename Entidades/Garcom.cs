using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgetoRestaurante.Entidades
{
    internal class Garcom
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Garcom(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
