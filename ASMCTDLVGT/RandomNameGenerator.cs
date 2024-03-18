using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMCTDLVGT
{
    public class RandomNameGenerator
    {
        private static Random random = new Random();
        private static List<string> firstNameList = new List<string> { "An", "Bình", "Châu", "Dương", "Giang", "Hải", "Hoàng", "Hùng", "Hương", "Khoa","Hồ","Nguyễn" };
        private static List<string> lastNameList = new List<string> { "Nguyễn", "Trần", "Lê", "Phạm", "Huỳnh", "Hoàng", "Phan", "Vũ", "Võ", "Đặng","Huy","Kiên" };


        public static string GenerateRandomName()
        {
            string firstName = firstNameList[random.Next(firstNameList.Count)];
            string lastName = lastNameList[random.Next(lastNameList.Count)];
            return $"{lastName} {firstName} ";
        }
    }
}
