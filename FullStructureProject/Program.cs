using System.Text;

namespace FullStructureProject
{ class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Công cha như núi thái sơn");
            Console.WriteLine("Nghĩa mẹ như nước trong nguồn chảy ra!");
            Console.WriteLine("Các đối số đầu vào của bạn");  
            for (int i = 0; i < args.Length; i++) { 
                Console.Write(args[i]);            
            }
            Console.ReadLine();
        }
    }
}