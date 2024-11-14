using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgetoRestaurante.Servicos
{
    internal class Servico
    {
        Repositorio repositorio = new Repositorio();


        public void IncluirMesa()
        {
            Console.Write("Numero da MESA:");
            int mesa = int.Parse(Console.ReadLine());//'A cadeia de caracteres de entrada não estava em um formato correto.'

            repositorio.AdicionarMesaRepositorio(mesa);
            Console.WriteLine("Mesa adicionada");
        }
        public void IncluirGarcom()
        {
            Console.Write("Nome do novo garçom:");
            string garcom = Console.ReadLine();
            repositorio.AdicionarGarcomRepositorio(garcom);
        }
        public void IncluirProduto()
        {
            Console.Write("Nome do produto:");
            string nome = Console.ReadLine();
            Console.Write("Preço:");
            double preco = double.Parse(Console.ReadLine());
            repositorio.AdicionarProdutoRepositorio(nome, preco);
        }

        public void ListarRepositorio()
        {
            repositorio.ListarMesaRepositorio();
            Console.WriteLine("_________________________");
            repositorio.ListarGarcomRepositorio();
            Console.WriteLine("_________________________");
            repositorio.ListarProdutoRepositorio();
            Console.WriteLine("_________________________");
            repositorio.ListarPedidosAbertos();
            Console.WriteLine("_________________________");
            Console.WriteLine("Pressione uma tecla para continuar:");
            Console.ReadKey();

        }
        public void NovoPedido()
        {
            Console.WriteLine("adicione um novo pedido pf");
            repositorio.AbrirPedidoRepositorio();
        }
        public void FecharPedido()
        {
            Console.WriteLine("Fhechando pedido");
            repositorio.FecharPedidorepositorio();
        }
    }
}
