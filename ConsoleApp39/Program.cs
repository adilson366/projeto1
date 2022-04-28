using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o tamanho da matriz: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                Console.WriteLine("Digite o quatro numeros: ");

                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.WriteLine("Digite o valor para recorrencia: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + ", " + j);

                        if (i > 0)
                        {
                            Console.WriteLine("up: " + mat[(i - 1), j]);
                        }

                        if (i < m - 1)
                        {
                            Console.WriteLine("down: " + mat[(i + 1), j]);
                        }

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, (j - 1)]);
                        }

                        if (j < m - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, (j + 1)]);
                        }


                    }
                }
            }




        }
    }
}
