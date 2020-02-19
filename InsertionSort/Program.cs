using System;

public class InsertionSortExample
{
    void sort(int[] a)
    {
        int n = a.Length;

        for (int i = 1; i < n; i++)
        {
            int key = a[i];
            int j = i - 1;


            while (j >= 0 && a[j] > key)
            {
                a[j + 1] = a[j];
                j = j - 1;
            }
            a[j + 1] = key;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i]);
        }
    }

    public static void Main(String[] args)
    {
        int[] a = { 12, 11, 13, 5, 6 };
        InsertionSortExample ob = new InsertionSortExample();
        ob.sort(a);
    }
}
