using System;

namespace Homework4
{
    public class HW4
    {
        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public int [] GenerateRandomArray()
        {
            Console.WriteLine("Укажите размер массива:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Random rnd = new Random();
            Console.WriteLine("Массив:");
            for (int i = 0; i < length; i++)
            {

                array[i] = rnd.Next(0, 100);

                Console.Write($"{array[i]} ");
            }
            return array;
        }
        
        public int FindMinValueInArray(int minValue, int [] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }
        public int FindMaxValueInArray(int maxValue, int [] array)
        {
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        public int FindMinIndexInArray(int min, int[] array)
        {
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                    index = i;
                }
            }
            Console.WriteLine();
            return index;
        }
        public int FindMaxIndexInArray(int max, int[] array)
        {
            max = -1;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (max <= array[i])
                {
                    max = array[i];
                    index = i;
                }
            }
            Console.WriteLine();
            return index;
        }
     
        public int CountSumOfOddNumbersInArray(int sum, int[] array)
        {
            for (int i = 1; i < array.Length; i += 2) 
            {
                sum += array[i];

            }
            return sum;
            
        }
        public void PrintArrayInReverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;

            }
        }
        public void PrintArray(int[] array)
        {
            Console.Write($"\nОтсортированный массив:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
        public int CountEvenNumbers(int count, int [] array)
        {
            
            foreach (int x in array)
            {
                if (x % 2 == 1)
                {
                    count++;
                }

            }
            return count;
        }

        public void DivideArrayByTwo(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[i + array.Length - array.Length / 2];
                array[i + array.Length - array.Length / 2] = tmp;
            }
        }

        public void CompleteBubbleSort (int[] array)
        {
            int b,c;
            for (b = 0; b < array.Length; b++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        c = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = c;
                    }
                }
            }
        }

        public void CompleteSelectSort(int[] array)
        {
            int min = array[0];
            int temp = 0;
            int idx = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                idx = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[idx] < array[j])
                    {

                        idx = j;
                    }

                }
                temp = array[i];
                array[i] = array[idx];
                array[idx] = temp;
            }
        }

        public void SolveTask1()
        {
            int[] array = GenerateRandomArray();
            int minValue = array[0];
            minValue = FindMinValueInArray(minValue, array);
            Console.WriteLine();
            Console.WriteLine("Минимальное число в массиве:");
            Console.WriteLine(minValue);
        }

        public void SolveTask2()
        {
            int[] array = GenerateRandomArray();
            int maxValue = array[0];
            maxValue = FindMaxValueInArray(maxValue, array);
            Console.WriteLine();
            Console.WriteLine("Максимальное число в массиве:");
            Console.WriteLine(maxValue);
        }
        public void SolveTask3()
        {
            int[] array = GenerateRandomArray();
            int min = array[0];
            int index = FindMinIndexInArray(min, array);
            Console.WriteLine($"Индекс минимального элемента:{index}");
        }

        public void SolveTask4()
        {
            int[] array = GenerateRandomArray();
            int max = 0;
            int index = 0;
            index = FindMaxIndexInArray(max, array);
            Console.WriteLine($"Индекс максимального элемента:{index}");
        }

        public void SolveTask5()
        {
            int[] array = GenerateRandomArray();
            int sum = 0;
            sum = CountSumOfOddNumbersInArray(sum, array);
            Console.WriteLine();
            Console.WriteLine($"Сумма нечетных элементов массива: {sum}");

        }

        public void SolveTask6()
        {
            int[] array = GenerateRandomArray();
            PrintArrayInReverse(array);
            PrintArray(array);
            
            
        }

        public void SolveTask7()
        {
            int[] array = GenerateRandomArray();
            int count = 0;
            count = CountEvenNumbers(count, array);
            Console.WriteLine();
            Console.WriteLine($"Количество нечетных элементов: {count}");
        }

        public void SolveTask8()
        {
            int[] array = GenerateRandomArray();
            DivideArrayByTwo(array);
            PrintArray(array);
        }

        public void SolveTask9()
        {
            int[] array = GenerateRandomArray();
            CompleteBubbleSort(array);
            PrintArray(array);

        }

        public void SolveTask10()
        {
            int[] array = GenerateRandomArray();
            CompleteSelectSort(array);
            PrintArray(array);


        }
    }
}
