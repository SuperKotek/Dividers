using System;
using System.Collections.Generic;

namespace MathHelper
{
    /// <summary>
    /// Вспомогательный класс для работы с числами
    /// </summary>
    public static class NumberHelper
    {
        /// <summary>
        /// Получение всех делителей числа
        /// Список делителей
        /// </summary>
        /// <param name="n">Введенное число
        /// должно быть задано натуральным числом типа int</param>
        /// returns>Список делителей</returns>
        public static List<int> GetAllDivisors(int n)
        {
            var result = new List<int>();
            if (n <= 0) return result;

            for (int i = 1; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    result.Add(i);
                    if (i != n / i)
                        result.Add(n / i);
                }
            }
            result.Sort();
            return result;
        }

        /// <summary>
        /// Нахождение чисел с 5 делителями в диапазоне
        /// Список делителей
        /// </summary>
        /// <param name="m">число, начало диапозона
        /// должно быть задано натуральным числом типа int</param>
        /// <param name="n">число, конец диапазона
        /// должно быть задано натуральным числом типа int</param>
        /// returns>Список делителей</returns>
        public static List<int> FindNumbersWith5Divisors(int m, int n)
        {
            List<int> res = new List<int>();
            if (m > n) return res;

            int maxP = (int)Math.Pow(n, 0.25) + 2;
            var primes = GeneratePrimesUpTo(maxP);

            foreach (var p in primes)
            {
                int num = p * p * p * p;
                if (num >= m && num <= n)
                    res.Add(num);
            }
            return res;
        }

        /// <summary>
        /// Факторизация числа
        /// Число, в форме простых множителей
        /// </summary>
        /// <param name="number">Введенное число
        /// должно быть задано натуральным числом типа int</param>
        /// returns>Число, в форме простых множителей</returns>
        public static Dictionary<int, int> Factorize(int number)
        {
            var factors = new Dictionary<int, int>();
            if (number < 2) return factors;

            if (number % 2 == 0)
            {
                int count = 0;
                while (number % 2 == 0)
                {
                    number /= 2;
                    count++;
                }
                factors[2] = count;
            }

            int divisor = 3;
            while (number > 1)
            {
                if (number % divisor == 0)
                {
                    int cnt = 0;
                    while (number % divisor == 0)
                    {
                        number /= divisor;
                        cnt++;
                    }
                    factors[divisor] = cnt;
                }
                divisor += 2;
            }
            return factors;
        }

        /// <summary>
        /// Генерация первых N простых чисел (базовый метод)
        /// Список простых чисел
        /// </summary>
        /// <param name="count">Количество вычисляемых простых чисел
        /// должно быть задано натуральным числом типа int</param>
        /// returns>Список простых чисел</returns>
        public static List<int> GenerateFirstPrimes(int count)
        {
            var primes = new List<int>();
            int num = 2;
            while (primes.Count < count)
            {
                if (IsPrime(num)) primes.Add(num);
                num = num == 2 ? 3 : num + 2;
            }
            return primes;
        }

        /// <summary>
        /// Генерация первых N простых чисел (Решето Эратосфена)
        /// Список простых чисел
        /// </summary>
        /// <param name="count">Количество вычисляемых простых чисел
        /// должно быть задано натуральным числом типа int</param>
        /// returns>Список простых чисел</returns>
        public static List<int> GeneratePrimesSieve(int count)
        {
            if (count < 1) return new List<int>();
            int limit = ApproximatePrimeBound(count);
            var sieve = new bool[limit + 1];
            Array.Fill(sieve, true);
            sieve[0] = sieve[1] = false;

            for (int i = 2; i * i <= limit; i++)
            {
                if (sieve[i])
                {
                    for (int j = i * i; j <= limit; j += i)
                        sieve[j] = false;
                }
            }

            var primes = new List<int>();
            for (int i = 2; primes.Count < count && i <= limit; i++)
            {
                if (sieve[i]) primes.Add(i);
            }
            return primes;
        }

        /// <summary>
        /// Вычисление наибольшего общего делителя двух чисел (алгоритм Евклида)
        /// Наибольший общий делитель
        /// </summary>
        /// <param name="a">Первое введенное число
        /// должно быть задано натуральным числом типа int</param>
        /// <param name="b">Второе введенное число
        /// должно быть задано натуральным числом типа int</param>
        /// returns>Наибольший общий делитель</returns>
        public static int FindGCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        /// <summary>
        /// Вычисление наименьшего общего кратного двух чисел
        /// Наименьшее общее кратное
        /// </summary>
        /// <param name="a">Первое введенное число
        /// должно быть задано натуральным числом типа int</param>
        /// <param name="b">Второе введенное число
        /// должно быть задано натуральным числом типа int</param>
        /// returns>Наибольший общий делитель</returns>
        public static int FindLCM(int a, int b)
        {
            if (a == 0 || b == 0) return 0;
            return Math.Abs(a * b) / FindGCD(a, b);
        }

        /// <summary>
        /// Генерация простых чисел до указанного предела
        /// Список простых чисел
        /// </summary>
        /// <param name="limit">Предел, до которого генерируются простые числа
        /// должно быть задано натуральным числом типа int</param>
        /// returns>Список простых чисел</returns>
        private static List<int> GeneratePrimesUpTo(int limit)
        {
            var primes = new List<int>();
            for (int i = 2; i <= limit; i++)
            {
                if (IsPrime(i)) primes.Add(i);
            }
            return primes;
        }

        /// <summary>
        /// Проверка числа на простоту
        /// Значение True или False (простое число или нет)
        /// </summary>
        /// <param name="number">Проверяемое число
        /// должно быть задано натуральным числом типа int</param>
        /// returns>Значение True или False</returns>
        private static bool IsPrime(int number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int max = (int)Math.Sqrt(number);
            for (int i = 3; i <= max; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Приблизительная оценка границы для N-го простого числа
        /// Значение предела списка прстых чисел
        /// </summary>
        /// <param name="count">Количество чисел
        /// должно быть задано натуральным числом типа int</param>
        /// returns>Значение предела списка прстых чисел</returns>
        private static int ApproximatePrimeBound(int count)
        {
            return count < 6 ? 12 : (int)(count * Math.Log(count) + count * Math.Log(Math.Log(count)));
        }
    }
}