﻿int sum(params int[] arr)
{
    int s = 0;
    foreach (int x in arr)
        s = s + x;
    return s;
}
Console.WriteLine(sum());
Console.WriteLine(sum(1, 4, 9));
Console.WriteLine(sum(1,43,467,23));