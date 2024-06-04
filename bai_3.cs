using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool running = true;
        while (running)
        {
            Console.WriteLine("Chọn chức năng:");
            Console.WriteLine("1. Tính tổng mảng số nguyên không dấu kích thước 2 byte");
            Console.WriteLine("2. Tính tổng mảng số nguyên có dấu kích thước 2 byte");
            Console.WriteLine("3. Thoát");

            Console.Write("Nhập lựa chọn (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateUnsignedSum();
                    break;
                case 2:
                    CalculateSignedSum();
                    break;
                case 3:
                    running = false;
                    Console.WriteLine("Đã thoát khỏi chương trình.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CalculateUnsignedSum()
    {
        ushort[] unsignedArray;
        int sum = 0;

        Console.Write("Nhập các số nguyên không dấu kích thước 2 byte (tối đa 10 số, cách nhau bằng dấu cách): ");
        string[] inputArray = Console.ReadLine().Split();
        unsignedArray = new ushort[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            unsignedArray[i] = ushort.Parse(inputArray[i]);
            sum += unsignedArray[i];
        }

        Console.WriteLine($"Tổng các số trong mảng: {sum}");
    }

    static void CalculateSignedSum()
    {
        short[] signedArray;
        int sum = 0;

        Console.Write("Nhập các số nguyên có dấu kích thước 2 byte (tối đa 10 số, cách nhau bằng dấu cách): ");
        string[] inputArray = Console.ReadLine().Split();
        signedArray = new short[inputArray.Length];

        for (int i = 0; i < inputArray.Length; i++)
        {
            signedArray[i] = short.Parse(inputArray[i]);
            sum += signedArray[i];
        }

        Console.WriteLine($"Tổng các số trong mảng: {sum}");
    }
}