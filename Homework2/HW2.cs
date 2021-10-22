using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class HW2
    {
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            int result = CalcResult(a, b);
            Console.WriteLine($"{result}");
        }
        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public int CalcResult(int a, int b)
        {
            if (a > b)
            {
                int sum = a + b;
                return sum;

            }
            else if (a == b)
            {
                int mult = a * b;
                return mult;
            }
            else
            {
                int minus = a - b;
                return minus;
            }
        }

        public void SolveTask2()
        {
            int x = GetNumberFromUserModified("Введите число X");
            int y = GetNumberFromUserModified("Введите число Y");
            int z = ConvertInputToBinary(x, y);
        }
        public int GetNumberFromUserModified(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine()) > 0 ? 1 : 0;
            return number;
        }
        public int ConvertInputToBinary(int x, int y)
        {
            int z = 2 * y + x;
            switch (z)
            {
                case 1:
                    Console.WriteLine("Четвертая четверть");
                    break;
                case 2:
                    Console.WriteLine("Вторая четверть");
                    break;
                case 3:
                    Console.WriteLine("Первая четверть");
                    break;
                default:
                    Console.WriteLine("Третья четверть");
                    break;



            }
            return z;
        }

        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число А");
            int b = GetNumberFromUser("Введите число B");
            int c = GetNumberFromUser("Введите число С");
            string result = PrintNumbersInAscendingOrder(a, b, c);
            Console.WriteLine($"Решение третьей задачи:{result}");
        }
        public string PrintNumbersInAscendingOrder(int a,int b, int c)
        {
            int[] arr = { a, b, c };
            if (a > b && a > c)
            {
                if (c > b)
                {
                    return $"{b} {c} {a}";

                }
                else
                {
                    return $"{c} {b} {a}";
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    return $"{c} {a} {b}";
                }
                else
                {
                    return $"{a} {c} {b}";
                }
            }
            else
            {
                if (a > b)
                {
                    return $"{b} {a} {c}";
                }
                else
                {
                    return $"{a} {b} {c}";
                }
            }
            
        }

        public void SolveTask4()
        {
            int a = GetNumberFromUser("Введите число А");
            int b = GetNumberFromUser("Введите число B");
            int c = GetNumberFromUser("Введите число С");
            double[] result = SolveQuadraticEquation(a, b, c);
            Console.WriteLine("Решение четвертой задачи: ");
            string finalResult = AnalyzeArrayLength(result);
            Console.WriteLine($"{finalResult}");
        }


        public double[] SolveQuadraticEquation(int a,int b, int c)
        {

            double d = b* b - 4 * a * c;
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                double[] twoRoots = new double[] { x1, x2 };
                return twoRoots;

            }
            else if (d == 0)
            {
                double x = (-b / (2 * a));
                double[] oneRoot = new double[] { x };
                return oneRoot;

            }
            else
            {
                throw new ArgumentException("Нет действительных корней");
            }

        }

        public string  AnalyzeArrayLength(double[] result)
        {
            if (result.Length == 2)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    return $"{result[i]} ";
                }
            }
            else if (result.Length == 1)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    return $"{result[i]} ";
                }
            }
            return "нет действительных корней";
        }



        public void SolveTask5()
        {
            int a = GetNumberFromUser("Введите двухзначное число");
            string result = SwitchNumbersToWords(a);
            Console.WriteLine($"Результат решения пятой задачи:{result}");
        }
        
        public string SwitchNumbersToWords(int a)
        {
            string result = "";
            if (a < 10) 
            {
                throw new ArgumentException("Число должно быть двухзначным!");
            }
            int answer = a % 10;
            int answer2 = a / 10;

            if (a >= 10 && a < 20)
            {
                switch (answer)
                {
                    case 0:
                        result = "Десять";
                        break;
                    case 1:
                        result = "Одиннадцать";
                        break;
                    case 2:
                        result = "Двенадцать";
                        break;
                    case 3:
                        result = "Тринадцать";
                        break;
                    case 4:
                        result = "Четырнадцать";
                        break;
                    case 5:
                        result = "Пятнадцать";
                        break;
                    case 6:
                        result = "Шестнадцать";
                        break;
                    case 7:
                        result = "Семнадцать";
                        break;
                    case 8:
                        result = "Восемнадцать";
                        break;
                    case 9:
                        result = "Девятнадцать";
                        break;
                    default:
                        break;     
                }
                return result;
            }
            else
            {
                switch (answer2)
                {
                    case 2:
                        result = "Двадцать ";
                        break;
                    case 3:
                        result = "Тридцать ";
                        break;
                    case 4:
                        result = "Сорок ";
                        break;
                    case 5:
                        result = "Пятьдесят ";
                        break;
                    case 6:
                        result = "Шестьдесят ";
                        break;
                    case 7:
                        result = "Семдесят ";
                        break;
                    case 8:
                        result = "Восемьдесят ";
                        break;
                    case 9:
                        result = "Девяносто ";
                        break;
                    default:
                        break;
                        
                }
                switch (answer)
                {
                    case 1:
                        result = result + "один";
                        break;
                    case 2:
                        result = result + "два";
                        break;
                    case 3:
                        result = result + "три";
                        break;
                    case 4:
                        result = result + "четыре";
                        break;
                    case 5:
                        result = result + "пять";
                        break;
                    case 6:
                        result = result + "шесть";
                        break;
                    case 7:
                        result = result + "семь";
                        break;
                    case 8:
                        result = result + "восемь";
                        break;
                    case 9:
                        result = result + "девять";
                        break;
                    default:
                        break;
                }
                return result;
            }

        }
        




    }

}
