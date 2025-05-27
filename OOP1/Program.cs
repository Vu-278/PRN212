using OOP1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Tao 1 doi tuong danh muc:
Category c1 = new Category();
//Gan gia tri cho cac thuoc tinh
c1.Id = 27;
c1.Name = "Hoang Vu";
//goi ham xuat du lieu
c1.PrintInfor();

//Khoi tao nhan vien
Employee e1 = new Employee();
e1.Id = 1; //goi settet Property Id
e1.Id_Card = "00123"; //goi setter Property Id_card
e1.Name = "Vu";
e1.Email = "vunlhse181695@fpt.edu.vn";
e1.Phone = "0989516997";
//Goi ham xuat thong tin
e1.PrintInfor();
Console.WriteLine("---------------");
Console.WriteLine("Id cua e1 =" + e1.Id);
Console.WriteLine($"Name cua e1 =" + e1.Name);
Console.WriteLine("Email cua e1 = " + e1.Email);
Console.WriteLine($"Phone cua e1 = " + e1.Phone);

//Ta cung co the khoi tao doi tuong va cac gia tri cua thuoc tinh nhu sau:
Employee e2 = new Employee()
{
    Id = 2,
    Id_Card = "6455",
    Name = "Vy",
    Email = "vunlhse181695@fpt.edu.vn",
    Phone = "0989516997"
};
Console.WriteLine("-----E2-----");
e2.PrintInfor();

Console.WriteLine("=============");
Employee e3 = new Employee(3, "0091", "Vu", "hoangvu@gmail.com", "0989516997");
//goi ham xuat thong tin
e3.PrintInfor();
//hoac tu dong goi tostring() khi doi tuong duoc xuat ra man hinh:
Console.WriteLine(e3);

//thu dung Constructor mac dinh (0 
Employee e4 = new Employee();
Console.WriteLine(e4);

//Tao doi tuong Customer
Customer cus1 = new Customer()
{
    Id = "Cus1",
    Name = "Nguyen Luong Hoang Vu",
    Email = "vunlhse181695@fpt.edu.vn",
    Phone = "09895169970",
    Address = "S602"
};
cus1.PrintInfor();
cus1.Address = "S1007";
cus1.Phone = "0358745375";
Console.WriteLine("Thong tin customer sau khi chinh sua");
cus1.PrintInfor();  