using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FiltrandoMúltiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Numero de elementos: ");
            int n = int.Parse(Console.ReadLine());          //numero de elementos en el arreglo
            int[]arreglo= Console.ReadLine().Split().Select(int.Parse).ToArray();          //Introducir datos del arreglo separados por un espacio
            int k = int.Parse(Console.ReadLine());            //Numero a comparar
            for(int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] % k == 0)
                {
                    Console.Write(arreglo[i] + " ");  //Si el producto es 0, imprime el numero
                }
                else
                {
                    Console.Write(" X ");    //Otro caso, imprime X
                }
            }
            
            Console.WriteLine("\nFin");
            Console.ReadKey();
        }
    }
}
