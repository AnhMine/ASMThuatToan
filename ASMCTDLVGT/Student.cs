using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMCTDLVGT
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Point { get; set; }
        public Student() { }
        public Student(int id, string name, double point)
        {
            Id = id;
            Name = name;
            Point = point;
        }
        public void Add()
        {
            Console.WriteLine("Nhập thông tin sinh viên : ");

            // Biến để kiểm tra xem liệu người dùng đã nhập số hay không
            bool validInput = false;

            do
            {
                Console.Write("Nhập mã sinh viên: ");
                string idInput = Console.ReadLine();
                if (int.TryParse(idInput, out int idResult))
                {
                    Id = idResult;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Mã sinh viên phải là một số. Vui lòng nhập lại.");
                }
            } while (!validInput);

             validInput = false;

            do
            {
                Console.Write("Nhập họ tên sinh viên: ");
                string nameInput = Console.ReadLine();

                // Kiểm tra xem tên có chứa số không
                bool hasDigit = false;
                foreach (char c in nameInput)
                {
                    if (char.IsDigit(c))
                    {
                        hasDigit = true;
                        break;
                    }
                }

                if (!hasDigit)
                {
                    Name = nameInput;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Họ tên sinh viên không được chứa số. Vui lòng nhập lại.");
                }
            } while (!validInput);
            // Biến để kiểm tra xem liệu người dùng đã nhập số hay không
            validInput = false;

            do
            {
                Console.Write("Nhập điểm sinh viên: ");
                string pointInput = Console.ReadLine();
                if (double.TryParse(pointInput, out double pointResult))
                {
                    Point = pointResult;
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Điểm sinh viên phải là một số. Vui lòng nhập lại.");
                }
            } while (!validInput);
        }


        public static List<Student> GenerateRandomStudents(int count)
        {
            List<Student> students = new List<Student>();
            Random random = new Random();

            for (int i = 1; i <= count; i++)
            {
                string randomName = RandomNameGenerator.GenerateRandomName();
                double randomPoint = Math.Round(random.NextDouble() * 10, 1);
                students.Add(new Student(i, randomName, randomPoint));
            }

            return students;
        }
        public void View()
        {
            Console.WriteLine($"Mã: {Id} -- Tên:{Name} --- Điểm: {Point}");
        }
    }
}
