class Cliente
{
    public string Nome { get; set; }

    public string Endereco { get; set; }


    public void DadosCliente()
    {
        System.Console.WriteLine( "Olá " + Nome);
        System.Console.WriteLine("Seu Endereço é " + Endereco);
    }
}