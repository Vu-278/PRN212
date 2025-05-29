using OOP2;
using OOP2_Reuse_As_Library;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//Câu 1: C (Create)
//Dùng list để tạo 5 Employee, trong đó 4 Employee là chính thức
//và 1 Employee là thời vụ
List<Employee> employees = new List<Employee>();


FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Vũ";
e1.IdCard = "123";
e1.Birthday = new DateTime(2004, 8, 27);
Console.WriteLine("---Thông tin của Vũ---");
Console.WriteLine(e1);
Console.WriteLine("===> AGE = " + e1.TinhTuoi());

FulltimeEmployee e2 = new FulltimeEmployee();
e2.Id = 1;
e2.Name = "Cường";
e2.IdCard = "234";
e2.Birthday = new DateTime(2004, 8, 27);
Console.WriteLine("---Thông tin của Cường---");
Console.WriteLine(e2);
Console.WriteLine("===> AGE = " + e2.TinhTuoi());

FulltimeEmployee e3 = new FulltimeEmployee();
e3.Id = 1;
e3.Name = "An";
e3.IdCard = "345";
e3.Birthday = new DateTime(2004, 8, 27);
Console.WriteLine("---Thông tin của An---");
Console.WriteLine(e3);
Console.WriteLine("===> AGE = " + e3.TinhTuoi());

FulltimeEmployee e4 = new FulltimeEmployee();
e4.Id = 1;
e4.Name = "Long";
e4.IdCard = "755";
e4.Birthday = new DateTime(2004, 8, 27);
Console.WriteLine("---Thông tin của Long---");
Console.WriteLine(e4);
Console.WriteLine("===> AGE = " + e4.TinhTuoi());

ParttimeEmployee e5 = new ParttimeEmployee();
e5.Id = 1;
e5.Name = "Vy";
e5.IdCard = "123";
e5.Birthday = new DateTime(2004, 8, 27);
Console.WriteLine("---Thông tin của Vy---");
Console.WriteLine(e5);
Console.WriteLine("===> AGE = " + e5.TinhTuoi());




