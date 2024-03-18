using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMCTDLVGT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
		    Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            ListStudents list = new ListStudents();

            bool exitMenu = false;
            do
            {
                Console.Clear();
                list.Menu();
                Console.Write("Nhập yêu cầu: ");
                int quantity = int.Parse(Console.ReadLine());

                switch (quantity)
                {
           
                    case 1:
                        Console.Clear();
                        Console.WriteLine("========= Xuất danh sách sinh viên ===========");
                        list.ExportList();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("========= Tìm kiếm thông tin sinh viên theo mã ===========");
                        list.SearchStudentByID();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("========= Tìm kiếm thông tin sinh viên theo tên ===========");
                        list.SerachStudentByName();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("========= Sắp xếp sinh viên tăng dần theo điểm ===========");
                        list.SortStudent();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("========= Xoá thông tin sinh viên theo mã ===========");
                        list.DeleteStudentById();
                        break;
                    case 6: 
                        Console.Clear();
                        Console.WriteLine("========= Tạo danh sách sinh viên mới ===========");
                        list.AddNewList();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("========= Thêm sinh viên mới===========");
                        list.AddNewStudent();   
                        break ;
                }

                Console.WriteLine();
                Console.Write("Bạn có muốn quay về Menu không? (Y/N): ");
                string choose = Console.ReadLine();
                if (!choose.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    exitMenu= true                        ;
                }
                else
                {
                    exitMenu = false ;
                }    
            } while (exitMenu);

            Console.ReadKey();
        }
    }
}
