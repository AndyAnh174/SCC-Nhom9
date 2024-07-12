using System;
class Operator{    

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
    Console.WriteLine($"Kết quả: {num1} {operation} {num2} = {result});

}
    char operation = operationInput[0];
    Calculator calculator = new Calculator (num1, num2);
    double result = 0;

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