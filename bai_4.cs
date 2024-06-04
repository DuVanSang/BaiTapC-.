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
            Console.WriteLine("1. Kiểm tra số Palindrome");
            Console.WriteLine("2. Tính tổng mảng số nguyên có dấu");
            Console.WriteLine("3. Thoát");

            Console.Write("Nhập lựa chọn (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CheckPalindrome();
                    break;
                case 2:
                    CalculateArraySum();
                    break;
                case 3:
                    running = false;
                    Console.WriteLine("Chương trình đã kết thúc.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CheckPalindrome()
    {
        Console.Write("Nhập số nguyên không dấu kích thước 8 byte: ");
        ulong number = ulong.Parse(Console.ReadLine());

        if (IsPalindrome(number))
        {
            Console.WriteLine($"{number} là số Palindrome.");
        }
        else
        {
            Console.WriteLine($"{number} không phải là số Palindrome.");
        }
    }

    static bool IsPalindrome(ulong number)
    {
        ulong originalNumber = number;
        ulong reversedNumber = 0;

        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + (number % 10);
            number /= 10;
        }

        return originalNumber == reversedNumber;
    }

    static void CalculateArraySum()
    {
        Console.Write("Nhập các số nguyên có dấu kích thước 8 byte (tối đa 10 số, cách nhau bằng dấu cách): ");
        string[] inputArray = Console.ReadLine().Split();
        long[] signedArray = new long[inputArray.Length];
        long sum = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            signedArray[i] = long.Parse(inputArray[i]);
            sum += signedArray[i];
        }

        Console.WriteLine($"Tổng các số trong mảng: {sum}");
    }
}