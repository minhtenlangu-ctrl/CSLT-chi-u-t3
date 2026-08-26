using System;
using System.Collections.Generic;
using System.Text;

namespace CSLT_chiều_t3.buổi2
{
    internal class baitaptrenlop3
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số thứ nhất: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập số thứ hai: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- Kết quả phép tính ---");
            Console.WriteLine($"Phép cộng: {a} + {b} = {a + b}");
            Console.WriteLine($"Phép trừ:  {a} - {b} = {a - b}");
            Console.WriteLine($"Phép nhân: {a} x {b} = {a * b}");
            Console.WriteLine($"Phép chia: {a} / {b} = {a / b}");
            Console.WriteLine($"Chia lấy dư (mod): {a} mod {b} = {a % b}");
        }
    }
}
