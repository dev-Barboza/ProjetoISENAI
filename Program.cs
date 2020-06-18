using System;

namespace ExercicoISESI
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente x = new Cliente();
            x.Nome = "Matheus";
            x.Endereco = "Rua dos Morcegos,33";
            x.DadosCliente();
            
            Restaurante y = new Restaurante();
            System.Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            y.NomeFantasia = "Comida na Hora";
            Console.ResetColor();
            y.EnderecoRestauranete = "Rua da Paz , 35";
            y.MostrarDados();
            
            
            Pedido Ipedido= new Pedido();
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Bem vindo ! ");
            System.Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Digite Seu Pedido");
            Console.ResetColor();
            System.Console.WriteLine();
            Ipedido.Itens = Console.ReadLine();
            Ipedido.Restaurante = " Comida na Hora";
            System.Console.WriteLine();
            System.Console.WriteLine("Digite Seu nome");
            Ipedido.Cliente= Console.ReadLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Digite a Forma de Pagamento ");
            Ipedido.FormasDePagamentos= Console.ReadLine();
            Ipedido.PedidoPago = true;
            Ipedido.EntregarPedido();
            Console.ResetColor();
        }
    }
}
