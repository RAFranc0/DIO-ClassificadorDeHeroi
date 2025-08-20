using System;

namespace ClassificadorDeNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, nivel = string.Empty, continuar;
            int xp;

            Console.WriteLine("--- Esse é o Classificador de nível de Herói ---\n");

            do
            {
                do
                {
                    Console.WriteLine("Qual o nome do heroi ou da heroína?");
                    nome = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(nome));

                Console.WriteLine("\nE qual a quantidade de XP atual?");

                while (!int.TryParse(Console.ReadLine(), out xp))
                {
                    Console.WriteLine("Valor inválido! Digite um número inteiro para o XP:");
                }


                if (xp < 1000)
                    nivel = "Ferro";

                else if (xp < 2000)
                    nivel = "Bronze";

                else if (xp < 5000)
                    nivel = "Prata";

                else if (xp < 7000)
                    nivel = "Ouro";

                else if (xp < 8000)
                    nivel = "Platina";

                else if (xp < 9000)
                    nivel = "Ascendente";

                else if (xp < 10000)
                    nivel = "Imortal";

                else
                    nivel = "Radiante";


                Console.WriteLine($"\nO Herói ou a heroína {nome} está no nível {nivel}");

                Console.WriteLine("\nDeseja repetir a classificação? sim ou nao");
                continuar = Console.ReadLine();

            } while (continuar.Equals("sim", StringComparison.OrdinalIgnoreCase));
        }
    }

}