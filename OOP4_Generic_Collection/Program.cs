using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
/*
 * Sử dụng Generic List để quản lý nhân sự 
 * thực hiện đầy đủ tính năng CRUD
 * C-Create --> thêm mới nhân sự
 * R-Read/Retrieve --> Đọc : Truy vấn, tìm kiếm, sắp xếp
 * U-Update --> chỉnh sửa dữ liệu
 * D-Delete --> Xóa dữ liệu
 */

//Câu 1: C (Create)
//Dùng list để tạo 5 Employee, trong đó 4 Employee là chính thức
//và 1 Employee là thời vụ
List<Employee> employees = new List<Employee>();

FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Vũ";
e1.IdCard = "1";
e1.Birthday = new DateTime(2004, 8, 27);
employees.Add(e1);

FulltimeEmployee e2 = new FulltimeEmployee();
e2.Id = 1;
e2.Name = "Vũ";
e2.IdCard = "2";
e2.Birthday = new DateTime(2005, 11, 30);
employees.Add(e2);

FulltimeEmployee e3 = new FulltimeEmployee();
e3.Id = 1;
e3.Name = "Vũ";
e3.IdCard = "3";
e3.Birthday = new DateTime(2000, 5, 2);
employees.Add(e3);

FulltimeEmployee e4 = new FulltimeEmployee();
e4.Id = 1;
e4.Name = "Vũ";
e4.IdCard = "4";
e4.Birthday = new DateTime(1999, 7, 7);
employees.Add(e4);

ParttimeEmployee e5 = new ParttimeEmployee();
e5.Id = 1;
e5.Name = "Vũ";
e5.IdCard = "5";
e5.WorkingHour = 3;   
e5.Birthday = new DateTime(2002, 11, 28);
employees.Add(e5);

// Câu 2 R - Xuất toàn bộ nhân sự 
// cách xuất 1
Console.WriteLine("-------------- Danh sách nhân sự (C1) ---------------");
employees.ForEach(e => Console.WriteLine(e));
Console.WriteLine("-------------- Danh sách nhân sự (C2) ---------------");
foreach (var e in employees) { Console.WriteLine(e); }

// Câu 3 R -> Lọc ra nhân sự chính thức và tính tổng lương 
Console.WriteLine("-------------- Danh sách nhân sự chính thức ---------------");
List<FulltimeEmployee> fullTimeEmployees = employees.OfType<FulltimeEmployee>().ToList();
fullTimeEmployees.ForEach(e => Console.WriteLine(e));

Console.WriteLine("-------------- Danh sách nhân sự chính thức Cách 2 ---------------");
// Cách 2 : thông thường 
List<FulltimeEmployee> list2 = new List<FulltimeEmployee>();
foreach (var e in employees)
{
    if (e is FulltimeEmployee)
    {
        list2.Add(e as FulltimeEmployee);
    }
}
list2.ForEach(e => Console.WriteLine(e));



//Tổng lương 
double sum_salary = list2.Sum(e => e.calSalary());
Console.WriteLine("Tổng lương = " + sum_salary);


//Câu 4: R--> Sắp xếp danh sách nhân sự theo ngày tháng năm sinh 
for (int i = 0; i < employees.Count; i++)
{
    for (int j = 0; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if (ei.Birthday > ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }
    }
}

Console.WriteLine("-------------- Danh sách nhân sự nhân sự sau khi sắp xếp ---------------");
employees.ForEach(e => Console.WriteLine(e));

void UpdateEmployee(List<Employee> employees, string idCard)
{
    var emp = employees.FirstOrDefault(e => e.IdCard == idCard);
    if (emp != null)
    {
        Console.WriteLine("Nhập tên mới:");
        emp.Name = Console.ReadLine();

        Console.WriteLine("Nhập ngày sinh mới (yyyy-MM-dd):");
        DateTime birthday;
        if (DateTime.TryParse(Console.ReadLine(), out birthday))
        {
            emp.Birthday = birthday;
        }

        if (emp is ParttimeEmployee ptEmp)
        {
            Console.WriteLine("Nhập số giờ làm việc mới:");
            ptEmp.WorkingHour = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Cập nhật thành công.");
    }
    else
    {
        Console.WriteLine("Không tìm thấy nhân viên.");
    }
}

void DeleteEmployee(List<Employee> employees, string idCard)
{
    var emp = employees.FirstOrDefault(e => e.IdCard == idCard);
    if (emp != null)
    {
        employees.Remove(emp);
        Console.WriteLine("Đã xoá nhân viên.");
    }
    else
    {
        Console.WriteLine("Không tìm thấy nhân viên.");
    }
}

Console.WriteLine("---------- SỬA THÔNG TIN NHÂN VIÊN ----------");
UpdateEmployee(employees, "2"); // sửa nhân viên có IdCard là "2"

Console.WriteLine("---------- XÓA NHÂN VIÊN ----------");
DeleteEmployee(employees, "3"); // xóa nhân viên có IdCard là "3"

Console.WriteLine("---------- DANH SÁCH SAU KHI CẬP NHẬT ----------");
employees.ForEach(e => Console.WriteLine(e));

