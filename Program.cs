using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaciSB4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj redova: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Unesite broj kolona: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols]; //unos el matrice sa komandne linije

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix [{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            //Ispis el matrice u kodnoj liniji
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
