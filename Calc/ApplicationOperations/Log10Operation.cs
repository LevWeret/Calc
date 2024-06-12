namespace CalculatorCsharp;

public sealed class Log10Operation : DoubleMathOperation
{
    public Log10Operation(
        ILog10 executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Десятичный логарифм (log10)")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ILog10 executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}
