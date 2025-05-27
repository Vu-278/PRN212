// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
string ho = "Nguyen";
string tenlot = "Luong Hoang";
string ten = "Vu";
string fullname = ho + " " + tenlot + " " + ten;
Console.WriteLine(fullname);    
StringBuilder sb = new StringBuilder();
sb.Append(ho);
sb.Append(" ");
sb.Append(tenlot);
sb.Append(" ");
sb.Append(ten);
Console.WriteLine(sb.ToString());