using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Barac Obama",
    Birthday = new DateTime(1960, 11, 25)
};
Console.WriteLine("---Thông tin của Obama---");
Console.WriteLine($"Id={obama.Id}");
Console.WriteLine("Name = " + obama.Name);
Console.WriteLine("IdCard: " + obama.IdCard);
Console.WriteLine("Năm sinh = " +
                        obama.Birthday.ToString("dd/MM/yyy"));
Console.WriteLine("Mức lương của Obame nhận = " + obama.calSalary());
Console.WriteLine("-------------------------------------------------");

ParttimeEmployee trump = new ParttimeEmployee();
trump.Id = 2;
trump.Name = "Donald Trump";
trump.IdCard = "456";
trump.Birthday = new DateTime(1950, 12, 12);
trump.WorkingHour = 3;
Console.WriteLine("---Thông tin của TRUMP---");
Console.WriteLine($"Id={trump.Id}");
Console.WriteLine("Name = " + trump.Name);
Console.WriteLine("IdCard: " + trump.IdCard);
Console.WriteLine("Năm sinh = " +
                        trump.Birthday.ToString("dd/MM/yyy"));
Console.WriteLine("Mức lương của TRUMP nhận = " + trump.calSalary());
Console.WriteLine("-----Sử dụng toString()----");
Console.WriteLine(obama);
Console.WriteLine(trump);