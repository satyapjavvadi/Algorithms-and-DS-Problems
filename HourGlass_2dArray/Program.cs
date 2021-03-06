﻿using System;
class Solution
{

    static int R = 5;
    static int C = 5;

    // Complete the hourglassSum function below.
    static int findMaxSum(int[,] arr)
    {

        if (R < 3 || C < 3)
            return -1;
        int max_sum = int.MinValue;
        for (int i = 0; i < (R - 2); i++)
        {
            for (int j = 0; j < (C - 2); j++)
            {
                int sum = (arr[i,j] + arr[i,j + 1] + arr[i,j + 2] +
                                   arr[i + 1,j + 1] +
                           arr[i + 2,j] + arr[i + 2,j + 1] + arr[i + 2,j + 2]);
                max_sum = Math.Max(max_sum, sum);
            }
        }
        return max_sum;
    }

    static public void Main(String[] args)
    {
        int[,] mat = {{1, 2, 3, 0, 0},
                       {0, 0, 0, 0, 0},
                       {2, 1, 4, 0, 0},
                       {0, 0, 0, 0, 0},
                       {1, 1, 0, 1, 0}};
        int res = findMaxSum(mat);
        if (res == -1)
            Console.WriteLine("Not possible");
        else
            Console.WriteLine("Maximum sum of hour glass = "
                               + res);
    }
} 

