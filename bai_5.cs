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
            Console.WriteLine("1. Tìm giá trị lớn nhất và nhỏ nhất trong mảng");
            Console.WriteLine("2. Tính tổng các số trong mảng");
            Console.WriteLine("3. Thoát");

            Console.Write("Nhập lựa chọn (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    FindMaxMin();
                    break;
                case "2":
                    CalculateSum();
                    break;
                case "3":
                    running = false;
                    Console.WriteLine("Chương trình đã kết thúc.");
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void FindMaxMin()
    {
        Console.Write("Nhập các số thực kích thước 4 byte (tối đa 10 số, cách nhau bằng dấu cách): ");
        string[] inputArray = Console.ReadLine().Split();
        float[] floatArray = new float[inputArray.Length];

        float maxValue = float.MinValue;
        float minValue = float.MaxValue;

        for (int i = 0; i < inputArray.Length; i++)
        {
            floatArray[i] = float.Parse(inputArray[i]);

            if (floatArray[i] > maxValue)
            {
                maxValue = floatArray[i];
            }

            if (floatArray[i] < minValue)
            {
                minValue = floatArray[i];
            }
        }

        Console.WriteLine($"Giá trị lớn nhất: {maxValue}");
        Console.WriteLine($"Giá trị nhỏ nhất: {minValue}");
    }

    static void CalculateSum()
    {
        Console.Write("Nhập các số thực kích thước 4 byte (tối đa 10 số, cách nhau bằng dấu cách): ");
        string[] inputArray = Console.ReadLine().Split();
        float[] floatArray = new float[inputArray.Length];

        float sum = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            floatArray[i] = float.Parse(inputArray[i]);
            sum += floatArray[i];
        }

        Console.WriteLine($"Tổng các số trong mảng: {sum}");
    }
}