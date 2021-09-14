using System;

namespace Helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Console.WriteLine(soNguyenTo(10));
            //Console.WriteLine(soChinhPhuong(9));
            //Console.WriteLine(boiChungNhoNhat(8, 12));
            Console.WriteLine();
            Console.ReadKey();
        }

        public static bool soNguyenTo (int n)
        {
            if (n == 2) return true;
            for (int i = 2; i < Math.Sqrt(n); i+=2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        public static bool soChinhPhuong (int n)
        {
            int a = (int)(Math.Sqrt(n));
            if (a * a == n)
                return true;
            return false;
        }

        public static int uocChungLonNhat (int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        public static int boiChungNhoNhat (int a, int b)
        {
            int result = uocChungLonNhat(a, b);
            return a * b / result;
        }

        public static int max (int[] a)
        {
            int m = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > m)
                    m = a[i];
            }
            return m;
        }
    }
}
