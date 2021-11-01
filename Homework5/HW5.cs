using System;

namespace Homework5
{
    public class HW5
    {
        public int[,] GenerateRandomTwoDimensionalArray()
        {
            Console.WriteLine("Массив:");
            int[,] array = new int[4, 6];
            Random rnd = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 100);
                    Console.Write($"{array[i, j]}\t");
                }

                Console.WriteLine();
            }
            return array;

        }

        public int FindMaxValueInTwoDimArray(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }

            }
            return max;
        }

        public int FindMinValueInTwoDimArray(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                    }
                }

            }
            return min;
        }

        public int[] FindMinIndex(int[,] array)
        {
            int min = array[0, 0];
            int[] index = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        index[0] = i;
                        index[1] = j;
                    }
                }

            }
            return index;
        }

        public int[] FindMaxIndex(int[,] array)
        {
            int max = array[0, 0];
            int[] index = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        index[0] = i;
                        index[1]= j;
                    }
                }
            }
            return index;
        }
        public int FindTheNumberOfElements(int[,] array)
        {
            int counter = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i == 0 || array[i, j] > array[i - 1, j])
                        && (j >= array.GetLength(1) - 1 || array[i, j] > array[i, j + 1])
                        && (j == 0 || array[i, j] > array[i, j - 1])
                        && (i >= array.GetLength(0) - 1 || array[i, j] > array[i + 1, j]))
                    {
                        counter++;
                    }
                }
            }
            
            return counter;
        }

        public void ReverseTwoDimArray(int[,] array)
        {
            for (int i = 1; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {

                    int tmp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = tmp;


                }
            }
        }

        public void PrintTwoDimArray(int[,] array)
        {
            Console.WriteLine();
            Console.WriteLine($"Измененный массив:\t");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();

            }
        }

        public void SolveTask1()
        {
            int[,] array = GenerateRandomTwoDimensionalArray();
            int max = FindMaxValueInTwoDimArray(array);
            Console.WriteLine("");
            Console.WriteLine($"Максимальный элемент в массиве: {max}");
        }

        public void SolveTask2()
        {
            int[,] array = GenerateRandomTwoDimensionalArray();
            int min = FindMinValueInTwoDimArray(array);
            Console.WriteLine("");
            Console.WriteLine($"Минимальный элемент массива:{min}");

        }

        public void SolveTask3()
        {
            int[,] array = GenerateRandomTwoDimensionalArray();
            int [] result = FindMinIndex(array);
            Console.WriteLine($"\n минимальный элемент массива: {result[0]}, {result[1]}");
        }

        public void SolveTask4()
        {
            int[,] array = GenerateRandomTwoDimensionalArray();
            int[] result = FindMaxIndex(array);
            Console.WriteLine($"\n максимальный элемент массива: {result[0]}, {result[1]}");

        }
        public void SolveTask5()
        {
            int[,] array = GenerateRandomTwoDimensionalArray();
            int result = FindTheNumberOfElements(array);
            Console.WriteLine($"Число элементов с большими соседями:{result}\t");

        }

        public void SolveTask6()
        {
            int[,] array = GenerateRandomTwoDimensionalArray();
            ReverseTwoDimArray(array);
            PrintTwoDimArray(array);

        }

    }
}
