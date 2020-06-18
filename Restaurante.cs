using System;

class Restaurante 
{
    public string NomeFantasia { get; set; }

    public string EnderecoRestauranete { get; set; }


        public void MostrarDados()
        {
            System.Console.WriteLine(NomeFantasia);
            System.Console.WriteLine();
            System.Console.WriteLine(EnderecoRestauranete);
        }

    
}