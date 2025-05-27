using System;
using System.Text;

void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
void sort_arr(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
        }
    }
}

void sort_arr_while(int [] arr)
{
    int i = 0; int j = i + 1;
    while(i < arr.Length)
    {
        while(j < arr.Length)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }
        i++;
        j = i + 1;
    }
}

void sort_arr_dowhile(int [] arr)
{
    int i = 0; int j = i + 1;
    do
    {
        do
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }
        while (j < arr.Length);
        i++;
        j = i + 1;
    }
    while (i < arr.Length - 1);
}
void create_array(int[] arr)
{
    Random rd = new Random();
    for (int i = 0;i < arr.Length; i++)
    {
        arr[i] = rd.Next(100);
    }   
}

void print_array(int[] arr)
{
    foreach (int i in arr){
        Console.Write($"{i}\t");
    }
}
Console.OutputEncoding = Encoding.UTF8;
int[]arr = new int[10];
Console.WriteLine("------------------Su dung Do While------------------");
create_array(arr);
Console.WriteLine("Mang truoc khi sap xep");
print_array(arr);
Console.WriteLine();
Console.WriteLine("Mang sau khi sap xep");
sort_arr_dowhile(arr);
print_array(arr);