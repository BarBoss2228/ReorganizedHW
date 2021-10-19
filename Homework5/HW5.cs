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

        public void FindMinIndex(int[,] array)
        {
            int min = array[0, 0];
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        index1 = i;
                        index2 = j;
                    }
                }

            }
            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Индекс минимального элемента массива: {index1},{index2}");
        }

        public void FindMaxIndex(int[,] array)
        {
            int max = array[0, 0];
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        index1 = i;
                        index2 = j;
                    }
                }
            }
            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Индекс максимального элемента массива: {index1},{index2}");
        }
        public void FindSumOfElements(int[,] array)
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
            Console.WriteLine("");
            Console.WriteLine($"Число элементов с большими соседями:{counter}\t");
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
            FindMinIndex(array);
        }

        public void SolveTask4()
        {
            int[,] array = GenerateRandomTwoDimensionalArray();
            FindMaxIndex(array);

        }
        public void SolveTask5()
        {
            int[,] array = GenerateRandomTwoDimensionalArray();
            FindSumOfElements(array);

        }

        public void SolveTask6()
        {
            int[,] array = GenerateRandomTwoDimensionalArray();
            ReverseTwoDimArray(array);
            PrintTwoDimArray(array);

        }

    }
}
