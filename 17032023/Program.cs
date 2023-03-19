using System;

namespace _17032023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = "salam";
            //char c= 'a';

            //int counter = CharCount(name, c);
            //Console.WriteLine(counter);

            //int sumArr=SumArr(1,2,3,4,5,6,7,8,9);
            //Console.WriteLine(sumArr);

            //int cevre = Sahe(3);
            //Console.WriteLine(cevre);

            //Console.WriteLine(Sahe(4,5));

            //Console.WriteLine(Sahe(3,4,5,6));

            //Sahe(1);
            //Sahe(2,4);
            //Sahe(2,4,6,9);

            int[] array = { 6, 1, 2, 9, 3, 5, 4 };
            SortArray(array,true);
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }

        }

        static void SortArray(int[] arr, bool isReverse = false)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (!isReverse)
                    {
                        if (arr[i] < arr[j])
                        {
                            arr[i] = arr[i] + arr[j];
                            arr[j] = arr[i] - arr[j];
                            arr[i] = arr[i] - arr[j];
                        }
                    }
                    else
                    {
                        if (arr[i] > arr[j])
                        {
                            arr[i] = arr[i] + arr[j];
                            arr[j] = arr[i] - arr[j];
                            arr[i] = arr[i] - arr[j];
                        }
                    }
                }
            }
        }

        static int CharCount(string str, char c)
        {
            int count = 0;
            foreach (var item in str)
            {
                if (item == c)
                {
                    count++;
                }
            }
            return count;
        }

        static int SumArr(params int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }

        static int Sahe(int r)
        {
            int p = 3;
            return Convert.ToInt32(p * Math.Pow(r, 2));
        }

        static int Sahe(int a, int b)
        {
            return a * b;
        }

        static int Sahe(int r, int a, int b, int c)
        {
            int p = (a + b + c) / 2;
            return p * r;
        }
    }
}
