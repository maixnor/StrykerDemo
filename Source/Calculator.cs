namespace Source;

public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Sub(int a, int b)
    {
        return a - b;
    }

    public int Mul(int a, int b)
    {
        return a * b;
    }

    public int Div(int a, int b)
    {
        if (b is 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}