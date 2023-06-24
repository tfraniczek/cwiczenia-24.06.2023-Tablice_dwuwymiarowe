using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw1_tablica_rosnaco_malejaca
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj rozmiar tablicy: ");
            int Size = Convert.ToInt32(Console.ReadLine());
            if (Size <= 0)

            {
                Console.WriteLine("Podałeś nieprawidłowy rozmiar tablicy, nie może być mniejszy lub równy zero.");
            }
            else
            {
                int[,] array = new int[Size, Size];
                int number = 1;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            array[i, j] = number;
                            number++;
                        }
                    }
                    else
                    {
                        for (int j = array.GetLength(1) - 1; j >= 0; j--)
                        {
                            array[i, j] = number;
                            number++;
                        }
                    }
                }

                PrintArray(array);
            }
        }

            static void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write($"{array[i, j],4} ");
                    }
                    Console.WriteLine();
                }

            }
        
    }
}
