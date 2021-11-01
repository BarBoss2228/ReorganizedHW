using System;

namespace Homework3
{
    public class HW3
    {
        public void SolveTask1()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            string result = ExponentiateUserNumber(a, b);
            Console.WriteLine($"Результат первой задачи: {result}");
        }
        public int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public string ExponentiateUserNumber(int a,int b)
        {
            if (b > 0)
            {
                int c = ExponentiateUserNumberInAPositiveExponent(a, b);
                return $"{c}";
            }
            else if (b == 0)
            {
                return "1";
            }
            else
            {
                double z = ExponentiateUserNumberInANegativeExponent(a, b);
                return $"{z}";
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
            string result = PrintNumbersDividedByUserNumber(a);
            Console.WriteLine($"Результат второй задачи: {result}");
        }

        public string PrintNumbersDividedByUserNumber(int a)
        {
            int i = 1;
            string result = " ";
            do
            {
                
                
                result = $"{result } {a * i}\t";
                i++;
            }
            while (a * i < 1000);
            return result;
        }

        public void SolveTask3()
        {
            int a = GetNumberFromUser("Введите число а:");
            int result = FindPositiveInt(a);
            Console.WriteLine($"Результат третьей задачи: {result}");
        }
        public int FindPositiveInt(int a)
        {
            if (a == 0)
            {
                return 0;
            }
            int i = 1;
            do
            {
                i++;
            }
            while (i * i < a);
            return i - 1;
        }

        public void SolveTask4()
        {
            int a = GetNumberFromUser("Введите число а:");
            int result = FindTheGreatestDivisor(a);
            Console.WriteLine($"Решение четвертой задачи: {result}");
        }
        public int FindTheGreatestDivisor(int a)
        {
            int i = a;
            do
            {
                i--;
            }
            while (i >= 1 && a % i != 0);
            return i;
        }

        public void SolveTask5()
        {
            int a = GetNumberFromUser("Введите число а:");
            int b = GetNumberFromUser("Введите число b:");
            int sum = CalcSumFromRange(a,b);
            Console.WriteLine($"{sum}");

        }
        public int CalcSumFromRange(int a, int b)
        {
            
            int sum = 0;
           
            if (a < b)
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
            else
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
                return sum = 1;

            }
            else
            {
                sum = CycleForFibanacciNumber(n, prev1, prev2, sum);
            }
            return sum;
        }
        public int CycleForFibanacciNumber(int n,int prev1,int prev2,int sum)
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
            Console.WriteLine($"НОД: {sum}");

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
            double number;
            do
            {
                number = GetNumberFromUser("Введите положительное число:");

                if (number < 0)
                {
                    Console.WriteLine("Число отрицательное.");
                }
            } while (number < 0);
            Console.WriteLine($"Целое положительное число, которое является кубом целого числа {number} будет равным {SearchSquare(number)}");
        }
        public double SearchSquare(double number)
        {
            double rightLimit = number;
            double leftLimit = 0;
            double result = 0;

            while (rightLimit - leftLimit > 0.001)
            {
                result = (rightLimit + leftLimit) / 2;
                if (result * result * result  > number)
                {
                    rightLimit = result;

                }
                else
                {
                    leftLimit = result;
                }
            }
            return result;
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
            int result = PrintTheMirroredNumber(a);
            
            Console.WriteLine($"Результат решения десятой задачи: {result}");
        }

        public int PrintTheMirroredNumber(int a)
        {
            
            int result = 0;
            while (a != 0 )
            {
                
                int c = a % 10;
                result = result * 10 + c;
                a /= 10;
            }
            return result;
                
                
        }
        public void SolveTask11()
        {
            int a = GetNumberFromUser("Введите число");
            string result = CountOddNumbersInInput(a);
            Console.WriteLine($"Решение одинадцатой задачи: {result}");
        }
        public string CountOddNumbersInInput (int a)
        {
            string result = "";
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
                    result += i + " ";
                }
            }
            return result;
        }
        public void SolveTask12()
        {

            int a = GetNumberFromUser("Введите число а");
            int b = GetNumberFromUser("Введите число b");
            string result = FindTheSameNumbers(a, b);
            Console.WriteLine($"Решение двенадцатой задачи: {result}");
            
        }

        public string FindTheSameNumbers (int a, int b)
        {
            
            while (a > 0)
            {
                while (b > 0)
                {
                    if (a % 10 == b % 10)
                    {
                        
                        return "Yeees";
                    }
                    b /= 10;
                }
                a /= 10;
            }
            return "Soory,bro, maybe next time";
        }
    }
}
