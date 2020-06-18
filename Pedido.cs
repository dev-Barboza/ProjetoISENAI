using System;

class Pedido : Cliente
{
    public string Itens { get; set; }

    public string Cliente { get; set; }

    public string Restaurante { get; set; }

    public string FormasDePagamentos { get; set; }

    

    public bool PedidoPago { get; set; }


    public void EntregarPedido()
    {
        if(PedidoPago == true)
        
        System.Console.WriteLine("Pedido Pago ! .... Pedido Em Andamento ... Pedido Entregue");

        else{System.Console.WriteLine("Transação recusada,Pedido Cancelado ");}

        
        
        
    }
}