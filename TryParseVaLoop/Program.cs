//De tai:
//    Nhap vao 1 số >= 0, nếu nhập sai quy tắc 
//    thì yêu cầu nhập lại khi nào đúng mới dừng 
//    Nếu nhập đúng thì tính giai thừa của số này
using System.Text;

Console.OutputEncoding = Encoding.UTF8; 
int n = -1;
while (n < 0)
{
    Console.WriteLine("Nhập n >= 0 :");
    string input = Console.ReadLine();
    if(int.TryParse(input, out n) == true)
    {//khi vào đây thì n là số, nhưng có thể < 0
        if (n >= 0) //nhập đúng
            break;//khong bat nhap nua
        else
            Console.WriteLine("tui da noi la nhap >= 0 maaaa !!");
    }
    else
    {
        Console.WriteLine("Sai bet r fen oi, nhap so maa");
    }
}

int gt = 1;
for(int i = 1; i <= n; i++)
{
    gt = gt * i;
    Console.WriteLine($"{n} != {gt}");
}