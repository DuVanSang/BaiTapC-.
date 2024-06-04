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
            Console.WriteLine("1. Tính trung bình cộng của các số trong mảng");
            Console.WriteLine("2. Tìm giá trị lớn nhất và nhỏ nhất trong mảng");
            Console.WriteLine("3. Thoát");

            Console.Write("Nhập lựa chọn của bạn (1-3): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CalculateAverage();
                    break;
                case 2:
                    FindMaxMin();
                    break;
                case 3:
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CalculateAverage()
    {
        Console.Write("Nhập các số thực kích thước 8 byte (tối đa 10 số, cách nhau bằng dấu cách): ");
        string[] inputArray = Console.ReadLine().Split();
        double[] doubleArray = new double[inputArray.Length];

        double sum = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            doubleArray[i] = double.Parse(inputArray[i]);
            sum += doubleArray[i];
        }

        double average = sum / inputArray.Length;

        Console.WriteLine($"Trung bình cộng của các số trong mảng: {average}");
    }

    static void FindMaxMin()
    {
        Console.Write("Nhập các số thực kích thước 8 byte (tối đa 10 số, cách nhau bằng dấu cách): ");
        string[] inputArray = Console.ReadLine().Split();
        double[] doubleArray = new double[inputArray.Length];

        double maxValue = double.MinValue;
        double minValue = double.MaxValue;

        for (int i = 0; i < inputArray.Length; i++)
        {
            doubleArray[i] = double.Parse(inputArray[i]);

            if (doubleArray[i] > maxValue)
            {
                maxValue = doubleArray[i];
            }

            if (doubleArray[i] < minValue)
            {
                minValue = doubleArray[i];
            }
        }

        Console.WriteLine($"Giá trị lớn nhất: {maxValue}");
        Console.WriteLine($"Giá trị nhỏ nhất: {minValue}");
    }
}