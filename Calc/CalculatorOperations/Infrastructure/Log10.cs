namespace CalculatorCsharp;

public sealed class Log10 : ILog10
{
    public double Invoke(double num)
    {
        return Math.Log10(num);
    }
}