namespace Source;

public static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Sub(int a, int b)
    {
        return a - b;
    }

    public static int Mul(int a, int b)
    {
        return a * b;
    }

    public static int Div(int a, int b)
    {
        if (b is 0)
        {
            throw new DivideByZeroException();
        }
        return a / b;
    }
}