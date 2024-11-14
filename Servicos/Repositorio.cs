using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgetoRestaurante.Entidades;

namespace ProgetoRestaurante.Servicos
{
    internal class Repositorio
    {
        public List<int> Mesas = new List<int> { 00,01, 02, 03 };
        
        public List<Garcom> Garcoms = new List<Garcom>
        {
            new Garcom(01,"Andersom"),
            new Garcom(02,"Bruno")
        };
        public List<Produto> Produtos = new List<Produto>
        {
            new Produto(01,"Suco de laranja",10.00),
            new Produto(02,"Suco de uva",10.00)

        };


        public List<Pedido> Pedidos = new List<Pedido> { new Pedido(-1,"Andersom",null) };

        

        public void ListarProdutoRepositorio()
        {
            Console.WriteLine("Lista dos produtos cadastrados:");

            foreach (var item in Produtos)
            {
                Console.WriteLine($"Nome: {item.Nome} Preço: {item.Preco} Id: {item.Id}");
            }
            Console.WriteLine();
        }

        public void ListarGarcomRepositorio()
        {
            Console.WriteLine("Lista de Garçoms cadastrados");
            foreach (var item in Garcoms)
            {
                Console.WriteLine($"Nome: {item.Nome} Id: {item.Id} ");
            }
            Console.WriteLine();
        }

        public void ListarMesaRepositorio()
        {
            Console.WriteLine("Lista de mesas cadastradas");
            foreach (var item in Mesas)
            {
                Console.WriteLine(item.ToString()+" Mesa");
            }
            Console.WriteLine();
        }

        public void ListarPedidosAbertos()
        {

            Console.WriteLine("Mesas abertas com pedido:");

            foreach (var item in Pedidos)
            {
                
                Console.WriteLine($"Mesa {item.Mesa} ");
            }
            
        }

        public void AdicionarMesaRepositorio(int valor)
        {
            int mesa = valor;
            if (!Mesas.Contains(mesa))
            {
                Mesas.Add(valor);
                Console.WriteLine("Mesa adicionada com sucesso:");
            }
            else
            {
                Console.WriteLine("Essa mesa ja existe");
                ListarMesaRepositorio();

            }

        }
        public void AdicionarGarcomRepositorio(string valor)
        {
            int Soma = 1;
            foreach (var item in Garcoms)
            {

                Soma += 1;
            }
            Garcom garcom = new Garcom(Soma, valor);
            if (!Garcoms.Any(x => x.Nome == garcom.Nome))
            {
                Garcoms.Add(garcom);
                Console.WriteLine("Garçom adicionado com sucesso:");
            }
            else
            {
                Console.WriteLine("Esse nome de garçom ja existe alternativas EX:(nome/1) ou (nome/Sobrenome)");
                ListarGarcomRepositorio();
            }

        }
        public void AdicionarProdutoRepositorio(string nome, double preco)
        {
            int Soma = 1;
            foreach (var item in Produtos)
            {

                Soma += 1;
            }
            Produto produto = new Produto(Soma, nome, preco);
            if (!Produtos.Any(x => x.Nome == produto.Nome))
            {
                Produtos.Add(produto);
                Console.WriteLine("Produto adicionado com sucesso:");
            }
            else
            {
                Console.WriteLine("Esse produto ja existe alternativa EX:(nome/grande) ou (nome/pequeno)");
                ListarProdutoRepositorio();
            }

        }

        public void AbrirPedidoRepositorio()
        {
            Console.WriteLine("Abrindo novo pedido:");
            Console.Write("Numero da Mesa:");
            int Mesa = int.Parse(Console.ReadLine());
            if (!Pedidos.Any(x => x.Mesa == Mesa))
            {
                Console.WriteLine("Mesa aberta:");
            }
            else
            {
                Console.WriteLine("Essa mesa ja esta em uso:");
            }
            Console.WriteLine("Garçom Id: ");
            int IdGarcom = int.Parse(Console.ReadLine());
            Garcom garcom = Garcoms.FirstOrDefault(x => x.Id == IdGarcom); //garçom pode ter varias mesas
            string GarcomNome = garcom.Nome;
            Console.WriteLine("Lista de consumo:");
            List<Produto> ListConsumo = new List<Produto>();
            int N = 1000;
            while(N != 1001)
            {
                Console.Write("Produto Id:");
                int IdProduto = int.Parse((string)Console.ReadLine());
                Produto produto = Produtos.FirstOrDefault(x => x.Id == IdProduto);
                ListConsumo.Add(produto);
                Console.WriteLine("Produto adicionado");
                Console.WriteLine();
                Console.WriteLine("Enviar Cozinha: 1001/mais produtos 1 "); ;
                N = int.Parse(Console.ReadLine());
              

            }
            Pedidos.Add(new Pedido(Mesa,GarcomNome,ListConsumo));
           
            

        }
        public void FecharPedidorepositorio()
        {
            Console.Write("Numero da mesa:");
            int Mesa = int.Parse(Console.ReadLine());
            var valor = new Pedido(-10, "Andersom", null);
            Console.WriteLine();
            foreach(Pedido pedido in Pedidos)
            {
                Console.WriteLine();
                if(pedido.Mesa == Mesa)
                {
                    valor = new Pedido(pedido.Mesa,pedido.Garcom,pedido.Consumo);
                    Console.WriteLine("Pedido encontrado");
                  
                }
                else
                {
                    Console.WriteLine("Esse pedido nao existe");
                }

            }

            Console.WriteLine($"Mesa: {valor.Mesa} Garçom {valor.Garcom}");
            double Soma = 1;
            foreach(Produto produto in valor.Consumo)
            {
                Console.WriteLine($"Nome: {produto.Nome} Preço: {produto.Preco}");
                Soma += produto.Preco;
            }
            Soma -= 1;
            Console.WriteLine($"Total a Pagar:{Soma.ToString("F2", CultureInfo.InvariantCulture)}");
        }



    }
}
