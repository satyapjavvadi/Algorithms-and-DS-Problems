using System;

public class SpiralArray
{
    static void spiralPrint(int b, int r, int[,] a)
    {
        int t = 0, l = 0, i = 0;

        while (t <= b && l <= r)
        {

            for (i = l; i < r; ++i)
            {
                Console.WriteLine(a[t, i]);
            }
            t++;

            for (i = t; i < b; ++i)
            {
                Console.WriteLine(a[i, r - 1]);
            }
            r--;

            if (t < b)
            {
                for (i = r - 1; i >= l; --i)
                {
                    Console.WriteLine(a[b - 1, i]);
                }
                b--;
            }
            if (l < r)
            {

                for (i = b - 1; i >= t; --i)
                {
                    Console.WriteLine(a[i, l]);
                }
                l++;
            }
        }
    }
    static void Main(string[] args)
    {
        int R = 4;
        int C = 4;
        int[,] a = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
        spiralPrint(R, C, a);
    }
}
