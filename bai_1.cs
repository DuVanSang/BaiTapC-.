using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Tính toán với 2 số nguyên");
            Console.WriteLine("2. Tính tổng các số trong mảng");
            Console.WriteLine("3. Đảo ngược số nguyên không dấu");
            Console.WriteLine("4. Thoát chương trình");

            int choice;
            while (true)
            {
                try
                {
                    Console.Write("Nhập lựa chọn (1-4): ");
                    choice = int.Parse(Console.ReadLine());
                    if (choice >= 1 && choice <= 4)
                        break;
                    else
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Lỗi: Số nhập vào không hợp lệ. Vui lòng nhập lại.");
                }
            }

            switch (choice)
            {
                case 1:
                    TinhToanVoi2So();
                    break;
                case 2:
                    TinhTongMang();
                    break;
                case 3:
                    DaoNguocSo();
                    break;
                case 4:
                    Console.WriteLine("Kết thúc chương trình.");
                    return;
            }
        }
    }

    static void TinhToanVoi2So()
    {
        int a, b;

        while (true)
        {
            try
            {
                Console.Write("Nhập số nguyên a (4 byte): ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Nhập số nguyên b (4 byte): ");
                b = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Số nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        Console.WriteLine($"Tổng a + b: {a + b}");
        Console.WriteLine($"Hiệu a - b: {a - b}");
        Console.WriteLine($"Tích a * b: {a * b}");
        Console.WriteLine($"Thương a / b (số nguyên): {a / b}");
        Console.WriteLine($"Thương a / b (số thực): {(float)a / b}");
    }

    static void TinhTongMang()
    {
        Console.Write("Nhập các số nguyên có dấu (tối đa 10 số, cách nhau bằng dấu cách): ");
        string[] inputArray = Console.ReadLine().Split();
        int[] numbers = new int[inputArray.Length];

        int sum = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            numbers[i] = int.Parse(inputArray[i]);
            sum += numbers[i];
        }

        Console.WriteLine($"Tổng các số trong mảng: {sum}");
    }

    static void DaoNguocSo()
    {
        uint number;

        while (true)
        {
            try
            {
                Console.Write("Nhập số nguyên không dấu (4 byte): ");
                number = uint.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Số nhập vào không hợp lệ. Vui lòng nhập lại.");
            }
        }

        uint reversedNumber = 0;
        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + (number % 10);
            number /= 10;
        }

        Console.WriteLine($"Số đảo ngược: {reversedNumber}");
    }
}