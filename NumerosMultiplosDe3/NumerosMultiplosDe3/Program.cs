using System;

namespace NumerosMultiplosDe3
{
    public class NumerosMultiplosDe3
    {
        static void Main(string[] args)
        {
            int num, sw=1;
            


            while (sw == 1) 
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine("* ALGORITMO PARA CALCULAR LOS MULTIPLOS DE 3 *");
                Console.WriteLine("**********************************************");
                Console.WriteLine("");
                Console.WriteLine("Por favor ingrese un número:");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 3 == 0)
                {
                    Console.WriteLine($"El {num} es multiplo de 3");
                    Console.WriteLine("");
                }
                else 
                {
                    Console.WriteLine($"El {num} no es multiplo de 3");
                    Console.WriteLine("");
                }
                Console.WriteLine("Si desea ingresar otro número digite 1 ó 0 para finalizar!");
                sw = Convert.ToInt32(Console.ReadLine());
            }
  
        }
    }
}
