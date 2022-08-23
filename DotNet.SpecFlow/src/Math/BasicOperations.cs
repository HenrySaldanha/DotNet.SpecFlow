namespace Math;

public class BasicOperations : IBasicOperations
{
    public long Sum(int a, int b) => a + b;
    public long Subtract(int a, int b) => a - b;
    public long Multiply(int a, int b) => a * b;
    public double Divide(int a, int b) => (double)a / (double)b;
}