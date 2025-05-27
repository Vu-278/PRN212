// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");


void ham1(int n)
{
    n = 8;
    Console.WriteLine($"n trong ham = {n}");

}
Console.OutputEncoding = Encoding.UTF8;
int n = 5;
Console.WriteLine($"n truoc khi vao ham = {n}");
ham1(n);
Console.WriteLine($"n sau khi vao ham = {n}");

void ham2(ref int n)
{
    n = 8;
    Console.WriteLine($"n trong ham = {n}");
}
Console.WriteLine("--------------RED--------------");
n = 5;
Console.WriteLine($"n truoc khi vao ham = {n}");
ham2(ref n);
Console.WriteLine($"n sau khi vao ham = {n}");

int m;
ham2(ref m);// bao loi vi dong 24 ch co gia tri

void ham3(out int n)
{
    n = 8;
}