using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();//Ignore
            string str = Console.ReadLine();
            //int c = int.Parse(Console.ReadLine());// раскомментирвать для некоторых методов


            //var fun = CountSpecElements(str, c); //Количество элементов равных заданному
            //var fun = SumEvenPositiveElements(str); //Сумма четных положительных элементов
            //var fun = SumPositiveElementsInTheEvenPositions(str);//Сумма положительных элементов на четных местах
            //var fun = LessAverage(str);//Меньше среднего арифметического
            //var fun = SumDigitOfArray(str);//Сумма цифр массива
            //var fun = RemoveMinAndMaxElements(str);//Поменять местами минимальный и максимальный элементы
            //var fun = SumOfElementsBetweenMinAndMax(str);//Сумма элементов между минимальным и максимальным элементами массива
            //var fun = SumSequenceUnits(str);//Максимальное количество последовательных единиц
            //var fun = RemoveZeroesToEnd(str);//Передвижение нулей
            var fun = BeautifulMountain(str);//Красивая гора

            Console.WriteLine(fun);
        }
        public static string BeautifulMountain(string str)
        {
            int[] arrayInt = Array.ConvertAll(str.Split(), int.Parse);
            int countChangeDir = 0;
            int lastDir = 0;
            int currentDir = 0;
            for (int i = 1; i < arrayInt.Length; i++)
            {
                currentDir = CurrentDir(arrayInt[i - 1], arrayInt[i]);
                if (currentDir != lastDir)
                {
                    countChangeDir++;
                    lastDir = currentDir;
                }
                if (countChangeDir == 1 && lastDir != 1) return "NO";
            }
            if (countChangeDir == 2) return "YES";
            else return "NO";
        }
        private static int CurrentDir(int lastNumber, int nextNumber)
        {
            int dir = 0;
            if (lastNumber < nextNumber) dir = 1;
            else if (lastNumber > nextNumber) dir = -1;
            return dir;
        }

        public static string RemoveZeroesToEnd(string str)
        {
            string outstr = "";
            int[] arrayInt = Array.ConvertAll(str.Split(), int.Parse);
            for (int i = 0; i < arrayInt.Length; i++)
            {
                for (int j = arrayInt.Length - 2; j >= i; j--)
                {
                    if (arrayInt[j] == 0)
                    {
                        arrayInt[j] = arrayInt[j + 1];
                        arrayInt[j + 1] = 0;
                    }
                }
                outstr += arrayInt[i] + " ";
            }
            return outstr;
        }

        public static int SumSequenceUnits(string str)
        {
            int[] arrayInt = Array.ConvertAll(str.Split(), int.Parse);
            int sum = 0;
            int count = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] == 1)
                {
                    count++;
                    if (count > sum) sum = count;
                }
                else count = 0;
            }
            return sum;
        }

        public static int SumOfElementsBetweenMinAndMax(string str)
        {
            int[] arrayInt = Array.ConvertAll(str.Split(), int.Parse);
            int indxMin = Array.IndexOf(arrayInt, arrayInt.Min());
            int indxMax = Array.IndexOf(arrayInt, arrayInt.Max());
            int sum = 0;
            if (indxMin < indxMax)
            {
                for (int i = indxMin + 1; i < indxMax; i++)
                    sum += arrayInt[i];
            }
            else if (indxMax < indxMin)
            {
                for (int i = indxMax + 1; i < indxMin; i++)
                    sum += arrayInt[i];
            }

            return sum;
        }

        public static string RemoveMinAndMaxElements(string str)
        {
            /*
             * Дана последовательность nn целых различных чисел.
             * Необходимо поменять местами минимальный и максимальный элементы.
             * Входные данные
             * В первой строке задается одно натуральное число n, не превосходящее 100.
             * Во второй строке вводятся n целых различных чисел, каждое из которых по модулю не превосходит 100. 
             * Выходные данные
             * Поменять местами минимальный и максимальный элементы и вывести измененный массив
             */
            int[] arrayInt = Array.ConvertAll(str.Split(), int.Parse);
            int min = arrayInt.Min();
            int max = arrayInt.Max();
            string outstr = "";
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (arrayInt[i] == min) arrayInt[i] = max;
                else if (arrayInt[i] == max) arrayInt[i] = min;
                outstr += arrayInt[i] + " ";
            }
            return outstr;
        }

        /// <summary>
        /// Считает сумму цифр в данной последовательности чисел
        /// </summary>
        public static int SumDigitOfArray(string str)
        {
            /*
             * Дана последовательность n целых чисел.
             * Необходимо найти сумму всех цифр массива.
             * Например, если дан массив [25, 36, 78], то сумма всех его цифр будет равна 2+5+3+6+7+8=31.
             * Входные данные
             * В первой строке задается одно натуральное число n, не превосходящее 100.
             * Во второй строке вводятся n целых чисел, каждое из которых по модулю не превосходит 100. 
             * Выходные данные
             * Выведите сумму всех цифр массива.
             * Примечание: знак числа на цифры не влияет.
             */
            int sum = 0;
            foreach (char el in str)
            {
                if (char.IsDigit(el))
                    sum += (int)char.GetNumericValue(el);
            }
            return sum;
        }

        /// <summary>
        /// Считает количество чисел, которые меньше среднего арифметического в данной последовательности
        /// </summary>
        public static int LessAverage(string str)
        {
            /*
             * Дана последовательность n целых чисел.
             * Необходимо найти количество элементов, значение которых меньше среднего арифметического, взятого от всех элементов массива.
             * Входные данные
             * В первой строке задается одно натуральное число n, не превосходящее 100.
             * Во второй строке вводятся n целых чисел, каждое из которых по модулю не превосходит 100. 
             * Выходные данны
             * Выведите количество элементов, значение которых меньше среднего арифметического, взятого от всех элементов массива.
             */

            string[] arrayStr = str.Split();
            int[] arrayInt = Array.ConvertAll(arrayStr, int.Parse);
            int average = (int)arrayInt.Average();
            int count = 0;
            foreach (int el in arrayInt)
            {
                if (el < average)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Считает сумму положительных чисел, на четных местах в данной последовательности
        /// </summary>
        public static int SumPositiveElementsInTheEvenPositions(string str)
        {
            /*
             * Дана последовательность n целых чисел.
             * Необходимо найти сумму положительных элементов, которые расположены на четных местах.
             * Нумерация чисел начинается с единицы. Если таких элементов нет, нужно вывести 0. 
             * Входные данные
             * В первой строке задается одно натуральное число n, не превосходящее 100.
             * Во второй строке вводятся n целых чисел, каждое из которых по модулю не превосходит 100. 
             * Выходные данные
             * Выведите сумму положительных элементов, которые расположены на четных местах.
             */
            string[] arrayStr = str.Split();
            int[] arrayInt = Array.ConvertAll(arrayStr, int.Parse);
            int sum = 0;
            for (int i = 0; i < arrayInt.Length; i++)
            {
                if (i % 2 == 1 & arrayInt[i] > 0)
                    sum += arrayInt[i];
            }
            return sum;
        }

        /// <summary>
        /// Считает сумму четных положительных чисел в данной последовательности
        /// </summary>
        public static int SumEvenPositiveElements(string str)
        {
            /*
             * Дана последовательность n целых чисел. Необходимо найти сумму четных положительных элементов.
             * Входные данные
             * В первой строке задается одно натуральное число n, не превосходящее 100
             * Во второй строке вводятся n целых чисел, каждое из которых по модулю не превосходит 100. 
             * Выходные данные
             * Выведите сумму четных положительных элементов.
             */
            string[] arrayStr = str.Split();
            int[] arrayInt = Array.ConvertAll(arrayStr, int.Parse);
            int sum = 0;
            foreach (int elem in arrayInt)
            {
                if (elem > 0 && elem % 2 == 0)
                    sum += elem;
            }
            return sum;
        }

        /// <summary>
        /// Считает количество чисел в данной последовательности равных заданому
        /// </summary>
        public static int CountSpecElements(string str, int c)
        {

            /*
             * Дана последовательность n целых чисел и число c. Необходимо найти количество элементов, которые равны c
             * Входные данные
             * В первой строке задается одно натуральное число n, не превосходящее 100.
             * Во второй строке вводятся n целых чисел, каждое из которых по модулю не превосходит 100.
             * В следующей строке вводится  одно целое число c, по модулю не превосходящее 100.
             * Выходные данные
             * Выведите количество элементов последовательности, которые равны c.
             */

            string[] array = (str).Split();

            int count = 0;
            foreach (string el in array)
            {
                if (int.Parse(el) == c) count++;
            }
            return count;
        }
    }
}
