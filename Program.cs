using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgetoRestaurante.Entidades;
using ProgetoRestaurante.Servicos;

namespace ProgetoRestaurante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RESTAURANTE");
            Console.WriteLine();
            Servico servico = new Servico();

            int J = 2;
            for (int i = 1; i < J; i++)
            {
                Cabecalho();
                int N = int.Parse(Console.ReadLine());
                if (N == 1)
                {
                    servico.NovoPedido();

                }
                if(N == 2)
                {
                    servico.ListarRepositorio();
                }
                if (N == 3)
                {
                    servico.IncluirMesa();
              
                }
                if (N == 4)
                {
                    servico.IncluirGarcom();
                }
                if (N == 5)
                {
                    servico.IncluirProduto();
                }
                if(N == 6)
                {
                    servico.FecharPedido();
                }
                else
                {
                    Console.WriteLine("Alternativa invalida:");
                }
               Console.Clear();
                J += 1;
            }
            

        }
        static void Cabecalho()
        {
            Console.WriteLine("Pressione a tecla correspondente a ação desejada:");
            Console.WriteLine("Novo pedido Digite: 1");
            Console.WriteLine("Listar repositório do Restaurante Digite: 2");
            Console.WriteLine("Incluir Mesa ao repositório Digite: 3");
            Console.WriteLine("Incluir Garçom ao repositório Digite: 4");
            Console.WriteLine("Incluir Produto ao repositório Digite: 5");
            Console.WriteLine("Fechar Pedido: 6");
        }

    }
}
