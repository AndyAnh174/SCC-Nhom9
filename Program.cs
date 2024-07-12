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
    
        char operation = operationInput[0];
    Calculator calculator = new Calculator (num1, num2);
    double result = 0;

    switch (operation){
        case '+':
            result = calculator.Add();
            break;
        case '-':
            result = calculator.Subtract();
            break;
        case '*':
            result = calculator.Multiply();
            break;
        case '/':
            try
            {
                result = calculator.Divide();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            break;
        default:
            Console.WriteLine("Phép toán không hợp lệ.");
            return;
    }
    Console.WriteLine($"Kết quả: {num1} {operation} {num2} = {result}");

}
}

class Calculator
{

    private double num1;
    private double num2;

    public Calculator(double num1, double num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public double Add()
    {
        return num1 + num2;
    }

    public double Subtract()
    {
        return num1 - num2;
    }

    public double Multiply()
    {
        return (num1 * num2);
    }

    public double Divide()
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("Lỗi: Không thể chia cho 0");
        }
        return num1 / num2;
    }
}
