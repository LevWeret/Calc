namespace CalculatorCsharp;

public sealed class LnOperation : DoubleMathOperation
{
    public LnOperation(
        ILn executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Натуральный логарифм (ln)")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ILn executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}
