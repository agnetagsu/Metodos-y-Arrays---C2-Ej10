using System;

namespace Metodos_y_Arrays___C2_Ej10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] miarray = new int[11];
            int numero;

            Console.WriteLine("Escribe el numero");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < miarray.Length; i++)
            {
                miarray[i] = numero*i;
            }
            for (int i = 0; i < miarray.Length; i++)
            {
                Console.WriteLine(miarray[i]);
            }
        }
    }
}
