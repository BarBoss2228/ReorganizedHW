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
            int[] arr = PrintNumbersInAscendingOrder(a, b, c);
        }
        public int [] PrintNumbersInAscendingOrder(int a,int b, int c)
        {
            int[] arr = { a, b, c };
            if (a > b && a > c)
            {
                if (c > b)
                {
                    Console.WriteLine($"{b} {c} {a}");

                }
                else
                {
                    Console.WriteLine($"{c} {b} {a}");
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine($"{c} {a} {b}");
                }
                else
                {
                    Console.WriteLine($"{a} {c} {b}");
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine($"{b} {a} {c}");
                }
                else
                {
                    Console.WriteLine($"{a} {b} {c}");
                }
            }
            return arr;
        }

        public void SolveTask4()
        {
            int a = GetNumberFromUser("Введите число А");
            int b = GetNumberFromUser("Введите число B");
            int c = GetNumberFromUser("Введите число С");
            SolveQuadraticEquation(a, b, c);
        }

        public void SolveQuadraticEquation(int a,int b, int c)
        {
            double d = b* b - 4 * a * c;
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                double x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine($"Дискриминант больше нуля, первый корень:{x1}, второй корень {x2} ");

            }
            else if (d == 0)
            {
                double x = (-b / 2 * a);
                Console.WriteLine($"Дискриминант равен 0, корень равен: {x}");

            }
            else
            {
                Console.WriteLine("Дискриминант меньше нуля");
            }

        }

        public void SolveTask5()
        {
            int a = GetNumberFromUser("Введите двухзначное число");
            int d = a / 10;
            int u = a % 10;

            SwitchNumbersToWords(a, d, u);
        }
        
        public void SwitchNumbersToWords(int a,int d, int u)
        {

            if (d == 0)
            {
                SwitchVaruableU(u);
            }
            else if (d == 1)
            {
                SwitchVaruableA(a);
            }
            else
            {

                if (u == 0)
                {
                    SwitchVaruableD(d);

                }
                else
                {
                    string dec = "";
                    string un = "";
                    SwitchVaruablesDandU(d, u, dec, un);
                }  
            }

        }
        public void SwitchVaruableU(int u)
        {
            switch (u)
            {
                case 0:
                    Console.WriteLine("ноль");
                    break;
                case 1:
                    Console.WriteLine("один");
                    break;
                case 2:
                    Console.WriteLine("два");
                    break;
                case 3:
                    Console.WriteLine("три");
                    break;
                case 4:
                    Console.WriteLine("четыре");
                    break;
                case 5:
                    Console.WriteLine("пять");
                    break;
                case 6:
                    Console.WriteLine("шесть");
                    break;
                case 7:
                    Console.WriteLine("семь");
                    break;
                case 8:
                    Console.WriteLine("восемь");
                    break;
                case 9:
                    Console.WriteLine("девять");
                    break;
            }
        }
        public void SwitchVaruableA(int a)
        {
            switch (a)
            {
                case 10:
                    Console.WriteLine("десять");
                    break;
                case 11:
                    Console.WriteLine("одиннадцать");
                    break;
                case 12:
                    Console.WriteLine("двенадцать");
                    break;
                case 13:
                    Console.WriteLine("тринадцать");
                    break;
                case 14:
                    Console.WriteLine("четырнадцать");
                    break;
                case 15:
                    Console.WriteLine("пятнадцать");
                    break;
                case 16:
                    Console.WriteLine("шестнадцать");
                    break;
                case 17:
                    Console.WriteLine("семнадцать");
                    break;
                case 18:
                    Console.WriteLine("восемнадцать");
                    break;
                case 19:
                    Console.WriteLine("девятнадцать");
                    break;

            }
        }
        public void SwitchVaruableD(int d)
        {
            switch (d)
            {
                case 2:
                    Console.WriteLine("Двадцать");
                    break;
                case 3:
                    Console.WriteLine("Тридцать");
                    break;
                case 4:
                    Console.WriteLine("Сорок");
                    break;
                case 5:
                    Console.WriteLine("Пятьдесят");
                    break;
                case 6:
                    Console.WriteLine("Шестьдесят");
                    break;
                case 7:
                    Console.WriteLine("Семьдесят");
                    break;
                case 8:
                    Console.WriteLine("Восемьдесят");
                    break;
                case 9:
                    Console.WriteLine("Девяносто");
                    break;
            }
        }
        public void SwitchVaruablesDandU(int d, int u, string dec, string un)
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
            Console.WriteLine(dec + " " + un);
        }
           




    }

}
