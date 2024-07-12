// See https://aka.ms/new-console-template for more information
using System;
class Operator{    
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
    Console.WriteLine($"Kết quả: {num1} {operation} {num2} = {result});

}
