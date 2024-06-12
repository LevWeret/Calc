namespace CalculatorCsharp;

public sealed class Cot : ICot
{
    public double Invoke(double num)
    {
        return 1 / Math.Tan(num);
    }
}