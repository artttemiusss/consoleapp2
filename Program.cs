using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер матрицы n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер матрицы m");
            int m = int.Parse(Console.ReadLine());

            int[,] myArray = new int [n , m];

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i,j] = random.Next();
                }
            }

            for (int a = 0; a < myArray.GetLength(0); a++)
            {
                for (int b = 0; b < myArray.GetLength(1); b++)
                {
                    Console.Write(myArray[a,b] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
