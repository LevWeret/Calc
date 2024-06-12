namespace CalculatorCsharp;

public sealed class Tan : ITan
{
    public double Invoke(double num)
    {
        return Math.Tan(num);
    }
}