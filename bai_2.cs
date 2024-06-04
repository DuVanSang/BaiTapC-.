using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("\nChọn chức năng:");
            Console.WriteLine("1. Tìm số lớn nhất và nhỏ nhất");
            Console.WriteLine("2. Tính tổng các số chẵn");
            Console.WriteLine("3. Tính tổng từ 1 đến n");
            Console.WriteLine("4. Tính tổng các chữ số");
            Console.WriteLine("0. Thoát");

            Console.Write("Nhập lựa chọn (0-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FindMaxMin();
                    break;
                case "2":
                    SumEvenNumbers();
                    break;
                case "3":
                    SumFrom1ToN();
                    break;
                case "4":
                    SumDigits();
                    break;
                case "0":
                    Console.WriteLine("Tạm biệt!");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }
        }
    }

    static void FindMaxMin()
    {
        Console.Write("Nhập dãy số nguyên có dấu (tối đa 10 số, mỗi số cách nhau bằng dấu cách): ");
        string[] input = Console.ReadLine().Split();
        sbyte[] nums = new sbyte[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = sbyte.Parse(input[i]);
        }

        sbyte max = nums[0];
        sbyte min = nums[0];

        foreach (sbyte num in nums)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
        }

        Console.WriteLine($"Số lớn nhất: {max}");
        Console.WriteLine($"Số nhỏ nhất: {min}");
    }

    static void SumEvenNumbers()
    {
        Console.Write("Nhập dãy số nguyên có dấu (tối đa 10 số, mỗi số cách nhau bằng dấu cách): ");
        string[] input = Console.ReadLine().Split();
        sbyte[] nums = new sbyte[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            nums[i] = sbyte.Parse(input[i]);
        }

        sbyte evenSum = 0;
        foreach (sbyte num in nums)
        {
            if (num % 2 == 0)
                evenSum += num;
        }

        Console.WriteLine($"Tổng các số chẵn: {evenSum}");
    }

    static void SumFrom1ToN()
    {
        Console.Write("Nhập số nguyên không dấu (tối đa 255): ");
        byte n = byte.Parse(Console.ReadLine());
        int total = (n * (n + 1)) / 2;
        Console.WriteLine($"Tổng các số từ 1 đến {n}: {total}");
    }

    static void SumDigits()
    {
        Console.Write("Nhập số nguyên không dấu kiểu byte (tối đa 255): ");
        byte num = byte.Parse(Console.ReadLine());
        byte digitSum = 0;

        while (num > 0)
        {
            digitSum += (byte)(num % 10);
            num /= 10;
        }

        Console.WriteLine($"Tổng các chữ số trong {num}: {digitSum}");
    }
}
