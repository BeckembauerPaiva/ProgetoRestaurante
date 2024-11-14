using ProgetoRestaurante.Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgetoRestaurante.Servicos
{
    internal class Pedido
    {
        public int Mesa { get; set; }
        public string Garcom { get; set; }
        public List<Produto> Consumo { get; set; }
        public Pedido()
        {
            
        }

        public Pedido(int mesa, string garcom, List<Produto> consumo)
        {
            Mesa = mesa;
            Garcom = garcom;
            Consumo = consumo;
        }
       

       
    }
}
