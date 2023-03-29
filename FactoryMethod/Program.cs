using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoFactory cartaoFactory = null;
            
            ConsoleKey key = ConsoleKey.Play;
           
            while (!(key == ConsoleKey.Escape))
            {
                Console.WriteLine("Digite o tipo do cartão que gostaria de obter : ");
                string console = Console.ReadLine();
                switch (console.ToLower())
                {
                    case "black":
                        cartaoFactory = new BlackFactory(500000, 0);
                        break;
                    case "titanium":
                        cartaoFactory = new TitaniumFactory(100000, 100);
                        break;
                    case "platinum":
                        cartaoFactory = new PlatinumFactory(10000, 140);
                        break;
                    default:
                        break;
                }

                CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
                Console.WriteLine("\n Os detalhes do cartão : \n");
                Console.WriteLine("Tipo : {0} \n Limite do Cartão {1} \n Anuidade {2}\n ", cartaoCredito.TipoCartao, cartaoCredito.LimiteCredito, cartaoCredito.CobrancaAnual);

                Console.WriteLine("Aperta alguma tecla para escolher outro cartão ou ESC para sair: \n ");

                key = Console.ReadKey().Key;
            }
        }
    }


}