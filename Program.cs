using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Metodo metodo = new Metodo();

            Console.WriteLine("Qual a quantidade de votos válidos?");
            metodo.Valido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de votos brancos?");
            metodo.Branco = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de votos nulos?");
            metodo.Nulo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Você deseja \r\n 1 - Calcular a porcentagem de votos válidos? \r\n 2 - Calcular a porcentagem de votos brancos? \r\n 3 - Calcular a porcentagem de votos nulos?");
            int input = Convert.ToInt32(Console.ReadLine());


            if (input == 1)
                metodo.Vvalido();
            else
            {

                if (input == 2)
                    metodo.Vbranco();

                else
                {

                    if (input == 3)
                        metodo.Vnulo();

                }
            }

        }
    }
}
