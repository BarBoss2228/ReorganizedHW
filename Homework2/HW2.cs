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
            AnalyzeArrayLength(result);
            

            
            

               
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

        public void AnalyzeArrayLength(double[] result)
        {
            if (result.Length == 2)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write($"{result[i]} ");
                }
            }
            else if (result.Length == 1)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write($"{result[i]} ");
                }
            }

        }


        public void SolveTask5()
        {
            int a = GetNumberFromUser("Введите двухзначное число");
            int d = a / 10;
            int u = a % 10;

           string result = SwitchNumbersToWords(a, d, u);
            Console.WriteLine($"Результат решения пятой задачи:{result}");
        }
        
        public string SwitchNumbersToWords(int a,int d, int u)
        {

            if (d == 0)
            {
                string units = SwitchVaruableU(u);
                return units;
            }
            else if (d == 1)
            {
                string numbers = SwitchVaruableA(a);
                return numbers;
            }
            else
            {

                if (u == 0)
                {
                    string decimals = SwitchVaruableD(d);
                    return decimals;

                }
                else
                {
                    string dec = "";
                    string un = "";
                    string doubleNumbers = SwitchVaruablesDandU(d, u, dec, un);
                    return doubleNumbers;
                }  
            }

        }
        public string SwitchVaruableU(int u)
        {
            switch (u)
            {
                case 0:
                   
                    return "ноль";
                    
                case 1:
                    return "один";
                    
                case 2:
                    return "два";
                    
                case 3:
                    return "три";
                    
                case 4:
                    return"четыре";
                    
                case 5:
                    return "пять";
                    
                case 6:
                    return "шесть";
                    
                case 7:
                    return "семь";
                case 8:
                    return "восемь";
                case 9:
                    return "девять";
                    
            }
        }
        public string SwitchVaruableA (int a)
        {
            switch (a)
            {
                case 10:
                    return "десять";
                    
                case 11:
                    return "одиннадцать";
                    
                case 12:
                    return "двенадцать";
                   
                case 13:
                    return "тринадцать";
                   
                case 14:
                    return "четырнадцать";
                   
                case 15:
                    return "пятнадцать";
                   
                case 16:
                    return "шестнадцать";
                   
                case 17:
                    return "семнадцать";
                   
                case 18:
                    return "восемнадцать";
                   
                case 19:
                    return "девятнадцать";
                    

            }
        }
        public string SwitchVaruableD(int d)
        {
            switch (d)
            {
                case 2:
                    return "Двадцать";
                    
                case 3:
                    return "Тридцать";
                   
                case 4:
                    return "Сорок";
                    
                case 5:
                    return "Пятьдесят";
                    
                case 6:
                    return "Шестьдесят";
                    
                case 7:
                    return "Семьдесят";
                   
                case 8:
                    return "Восемьдесят";
                   
                case 9:
                    return "Девяносто";
                    
            }
        }
        public string SwitchVaruablesDandU(int d, int u, string dec, string un)
        {
            dec = "";
            un = "";

            switch (d)
            {
                case 2:
                    dec = "Двадцать";
                    break;
                case 3:
                    dec = "Тридцать";
                    break;
                case 4:
                    dec = "Сорок";
                    break;
                case 5:
                    dec = "Пятьдесят";
                    break;
                case 6:
                    dec = "Шестьдесят";
                    break;
                case 7:
                    dec = "Семьдесят";
                    break;
                case 8:
                    dec = "Восемьдесят";
                    break;
                case 9:
                    dec = "Девяносто";
                    break;
            }
            switch (u)
            {
                case 1:
                    un = "один";
                    break;
                case 2:
                    un = "два";
                    break;
                case 3:
                    un = "три";
                    break;
                case 4:
                    un = "четыре";
                    break;
                case 5:
                    un = "пять";
                    break;
                case 6:
                    un = "шесть";
                    break;
                case 7:
                    un = "семь";
                    break;
                case 8:
                    un = "восемь";
                    break;
                case 9:
                    un = "девять";
                    break;
            }
            return (dec + " " + un);
        }
           




    }

}
