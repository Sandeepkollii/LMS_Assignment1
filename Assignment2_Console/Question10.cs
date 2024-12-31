using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Console
{
    public class Question10
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of rows and columns for first matrix:");
            Console.Write("Rows : ");
            int rows1 = int.Parse(Console.ReadLine());
            Console.Write("Columns : ");
            int cols1 = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rows1, cols1];

            Console.WriteLine("Input elements in the first matrix :");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nInput the number of rows and columns for second matrix:");
            Console.Write("Rows : ");
            int rows2 = int.Parse(Console.ReadLine());
            Console.Write("Columns : ");
            int cols2 = int.Parse(Console.ReadLine());

            if (cols1 != rows2)
            {
                Console.WriteLine("Matrices cannot be multiplied!");
                return;
            }

            int[,] matrix2 = new int[rows2, cols2];

            Console.WriteLine("Input elements in the second matrix :");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            
            int[,] result = new int[rows1, cols2];

            
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            
            Console.WriteLine("\nThe First matrix is :");
            PrintMatrix(matrix1);

            Console.WriteLine("\nThe Second matrix is :");
            PrintMatrix(matrix2);

            Console.WriteLine("\nThe multiplication of two matrix is :");
            PrintMatrix(result);
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
