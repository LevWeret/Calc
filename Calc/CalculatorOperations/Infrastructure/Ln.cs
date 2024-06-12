namespace CalculatorCsharp;

public sealed class Ln : ILn
{
    public double Invoke(double num)
    {
        return Math.Log(num);
    }
}