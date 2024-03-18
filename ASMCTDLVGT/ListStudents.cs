using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASMCTDLVGT
{
    public class ListStudents
    {
        List<Student> listStudent = Student.GenerateRandomStudents(10);

        public void ExportList()
        {
            foreach (Student student in listStudent)
            {
                student.View();
            }
        }
        public void SearchStudentByID()
        {
            ExportList();


            Console.Write("Nhập ID cần tìm kiếm: ");
            int target = int.Parse(Console.ReadLine());

            bool found = false; 

            foreach (Student student in listStudent)
            {
                if (student.Id == target)
                {
                    student.View();
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy sinh viên có ID '{0}'.", target);
            }
        }


        public void SerachStudentByName()
        {
            ExportList();

            Console.Write("Nhập phần của tên cần tìm kiếm: ");
            string partialName = Console.ReadLine();
            bool found = false;

            foreach (var student in listStudent)
            {
                if (student.Name.IndexOf(partialName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    student.View();
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Không tìm thấy sinh viên có phần của tên '{0}'.", partialName);
            }

        }
        public void SortStudent()
        {

            int n = listStudent.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (listStudent[j].Point > listStudent[i].Point)
                    {
                        Student temp = listStudent[j];
                        listStudent[j] = listStudent[i];
                        listStudent[i] = temp;
                    }
                }
            }
            ExportList();

        }

        public void DeleteStudentById()
        {
            ExportList();
            Console.Write("Nhập ID cần xóa");
            int target = int.Parse(Console.ReadLine());
            bool found = false;
            foreach (Student student in listStudent)
            {
                if (student.Id == target)
                {
                    listStudent.Remove(student);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Không tìm thấy sinh viên có id '{0}'.", target);
            }

        }
        public void AddNewList()
        {
            listStudent.Clear();
            listStudent = Student.GenerateRandomStudents(10);
            Console.WriteLine("Đã tạo thành công danh sách sv mới");
            ExportList();
        }
        public void AddNewStudent()
        {
            do
            {
                Student student = new Student();
                student.Add();

                bool idExists = false;
                foreach (var existingStudent in listStudent)
                {
                    if (existingStudent.Id == student.Id)
                    {
                        idExists = true;
                        Console.WriteLine("ID đã tồn tại trong danh sách. Vui lòng nhập lại ID.");
                        break;
                    }
                }

                if (!idExists)
                {
                    listStudent.Add(student);
                    Console.Write("Bạn có muốn nhập tiếp không (Y/N): ");
                    string test = Console.ReadLine();
                    if (test.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                }

            } while (true);
        }


        public void Menu()
        {
            Console.WriteLine("==================Menu=========================");
            Console.WriteLine("*   1. Xuất danh sách thông tin sinh viên.    *");
            Console.WriteLine("*   2. Tìm kiếm thông tin sinh viên theo mã. *");
            Console.WriteLine("*   3. Tìm kiếm thông tin sinh viên theo tên.  *");
            Console.WriteLine("*   4. Sắp xếp sinh viên giảm dần theo điểm.  *");
            Console.WriteLine("*   5. Xoá thông tin sinh viên theo mã.       *");
            Console.WriteLine("*   6. Tạo danh sách sinh viên mới.           *");
            Console.WriteLine("*   7. Thêm sinh viên mới vào dánh sách.       *");
            Console.WriteLine("===============================================");
        }
        
     


    }
}
