using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class HW1
    {
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            double result = CalcFormula(a, b);
            Console.WriteLine($"Результат первой задачи: {result}");
        }

        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public double CalcFormula(int a, int b)
        {
            double result = (5 * a + b * b) / (b - a);
            return result;
        }

        public void SolveTask2()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            SwapNumbers(ref a, ref b);
            Console.WriteLine($"{a},{b}");
        }

        public void SwapNumbers(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            return;
        }
        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            int j = a / b;
            int h = a % b;
            
            Console.WriteLine($"{j},{h}");
        }
        public void SolveTask4()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            int c = GetNumberFromUser("Введите число c:");
            int x = SolveLinearEquation(a, b, c);
            Console.WriteLine($"{x}");
        }
        public int SolveLinearEquation(int a, int b, int c)
        {
            return (c - b )/ a;
        }
        public void SolveTask5()
        {
            int x1 = GetNumberFromUser("Введите число x1:");
            int y1 = GetNumberFromUser("Введите число y1:");
            int x2 = GetNumberFromUser("Введите число x2:");
            int y2 = GetNumberFromUser("Введите число y2:");
            int k = CalculateFactorK(x1, y1, x2, y2);
            int b = CalculateFactorB(k, x2, y2);
            Console.WriteLine($"Уравнение прямой: y = {k} x + {b}");
        }
        public int CalculateFactorK(int x1,int y1,int x2,int y2)
        {
            return (y1 - y2) / (x1 - x2);
        }
        public int CalculateFactorB(int k, int x2, int y2)
        {
            return y2 - (k * x2);
        }

        

    }
}
