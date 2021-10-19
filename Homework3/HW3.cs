using System;

namespace Homework3
{
    public class HW3
    {
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            ExponentiateUserNumber(a, b);
        }
        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public void ExponentiateUserNumber(int a,int b)
        {
            if (b > 0)
            {
                int c = ExponentiateUserNumberInAPositiveExponent(a, b);
                Console.WriteLine($"{c}");
            }
            else if (b == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                double z = ExponentiateUserNumberInANegativeExponent(a, b);
                Console.WriteLine($"{z}");
            }
        }

        public int ExponentiateUserNumberInAPositiveExponent(int a, int b)
        {
            int c = 1;
            for (int i = 1; i <= b; i++)
            {
                c = c * a;
            }
            return c;
        }
        public double ExponentiateUserNumberInANegativeExponent(int a, int b)
        {
            double z = 1;
            for (int i = 1; i <= Math.Abs(b); i++)
            {
                z = z / a;
            }
            return z;
        }

        public void SolveTask2()
        {
            int a = GetNumberFromUser("Введите число а:");
            PrinteNumbersDividedByUserNumber(a);
        }

        public void PrinteNumbersDividedByUserNumber(int a)
        {
            int i = 1;
            do
            {
                Console.WriteLine($"{a * i}");
                i++;
            }
            while (a * i < 1000);
        }

        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число а:");
            FindPositiveInt(a);
        }
        public void FindPositiveInt(int a)
        {
            int i = 1;
            do
            {
                i++;
            }
            while (i * i < a);
            Console.WriteLine($"{i - 1}");
        }

        public void SolveTask4()
        {
            int a = GetNumberFromUser("Введите число а:");
            FindTheGreatestDivisor(a);
        }
        public void FindTheGreatestDivisor(int a)
        {
            int i = a;
            do
            {
                i--;
            }
            while (i >= 1 && a % i != 0);
            Console.WriteLine($"{i}");
        }

        public void SolveTask5()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            int sum = PrintSumFromRange(a,b);
            Console.WriteLine($"{sum}");

        }
        public int PrintSumFromRange(int a, int b)
        {
            
            int sum = 0;
           
            if (a < b)
            {
                sum = CalcFormula1(a, b, sum);
            }
            else
            {
                sum = CalcFormula2(a, b, sum);
            }
            return sum;
        }
        private int CalcFormula1(int a, int b, int sum)
        {
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        private int CalcFormula2(int a, int b, int sum)
        {
            for (int i = b; i <= a; i++)
            {
                if (i % 7 == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        public void SolveTask6()
        {
            int n = GetNumberFromUser("Введите число N:");
            int sum = PrintFibonacciNumber(n);
            Console.WriteLine($"{sum}");
        }

        public int PrintFibonacciNumber (int n)
        {
            int prev1 = 1;
            int prev2 = 1;
            int sum = 0;
            if (n == 1 || n == 2)
            {
                Console.WriteLine("1");

            }
            else
            {
                sum = CycleForFibanacciNumber(n, prev1, prev2, sum);
            }
            return sum;
        }
        private int CycleForFibanacciNumber(int n,int prev1,int prev2,int sum)
        {
            for (int i = 3; i <= n; i++)
            {
                sum = prev1 + prev2;
                prev2 = prev1;
                prev1 = sum;
            }
            return sum;
        }

        public void SolveTask7()
        {
            int a = GetNumberFromUser("Введите число А");
            int b = GetNumberFromUser("Введите число B");
            int sum = FindTheGreatestCommonDivisor(a, b);
            
        }

        public int FindTheGreatestCommonDivisor (int a,int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = FindTheRemainderOfTheDivisionA(a, b);
                    //a = a % b;
                }
                else
                {
                    b = FindTheRemainderOfTheDivisionB(a, b);
                    //b = b % a;
                }
            }
            int sum = a + b;
            Console.WriteLine($"НОД: {sum}");
            return sum;

        
        }
        private int FindTheRemainderOfTheDivisionA(int a, int b)
        {
            a = a % b;
            return a;
        }
        private int FindTheRemainderOfTheDivisionB(int a, int b)
        {
            b = b % a;
            return b;
        }

        public void SolveTask8()
        {

        }

        public void SolveTask9()
        {
            int userInput = GetNumberFromUser("Введите число ");
            int numberOfOddNumbers = CountOddNumbersInUserInput(userInput);
            Console.WriteLine($"Количество нечетных цифр в числе равно {numberOfOddNumbers} !");
        }

        public int CountOddNumbersInUserInput(int userInput)
        {
            int numberOfOddNumbers = 0;
            if (userInput > 0)
            {
                for (int i = userInput; i != 0; i--)
                {
                    if (i % 2 != 0)
                    {
                        numberOfOddNumbers++;
                    }
                }
            }
            else
            {
                for (int i = userInput; i != 0; i++)
                {
                    if (i % 2 != 0)
                    {
                        numberOfOddNumbers++;
                    }
                }
            }
            return numberOfOddNumbers;
        }
        
        public void SolveTask10()
        {
            int a = GetNumberFromUser("Введите число");
            a = PrintTheMirroredNumber(a);
        }

        public int PrintTheMirroredNumber(int a)
        {
            Console.Write(a % 10);
            while ((a /= 10) != 0)
                Console.Write(a % 10);
            return a;
        }
        public void SolveTask11()
        {
            int a = GetNumberFromUser("Введите число");
            PrintNumbers(a);
        }
        public void PrintNumbers (int a)
        {
            int c = 0;
            int sumOdd = 0;
            int sumEven = 0;

            int z = 0;
            for (int i = 1; i <= a; i++)
            {
                z = i;
                sumOdd = 0;
                sumEven = 0;

                do
                {

                    c = z % 10;
                    z = z / 10;
                    if (c % 2 == 0)
                    {
                        sumEven = sumEven + c;
                    }
                    else
                    {
                        sumOdd = sumOdd + c;
                    }
                }
                while (z > 0);
                if (sumEven > sumOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void SolveTask12()
        {
            Console.WriteLine("Введите число A:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B:");
            int b = Convert.ToInt32(Console.ReadLine());
            while (a > 0)
            {
                while (b > 0)
                {
                    if (a % 10 == b % 10)
                    {
                        Console.WriteLine("Yeees");
                        return;
                    }
                    b /= 10;
                }
                a /= 10;
            }
            Console.WriteLine("Soory,bro, maybe next time");
        }
    }
}
