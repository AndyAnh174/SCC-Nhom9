
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

