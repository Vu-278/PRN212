﻿(int, double) SumAndAverage(params int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        sum += arr[i];
    double avg = sum/arr.Length;
    return (sum,avg);
}

int []arr = { 1, 2, 4, 5, 8, 34 };
(int s, double v) = SumAndAverage(arr);
Console.WriteLine($"SUM={s}");

Console.WriteLine($"AVERAGE = {v}");