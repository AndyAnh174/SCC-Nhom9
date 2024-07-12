using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập số thứ nhất: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Nhập số thứ hai: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Chọn phép toán (+, -, *, /): ");
        string operationInput = Console.ReadLine();
        if (string.IsNullOrEmpty(operationInput))
        {
            Console.WriteLine("Phép toán không hợp lệ.");
            return;
        }
    }
}

