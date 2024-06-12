namespace CalculatorCsharp;

public sealed class CotOperation : DoubleMathOperation
{
    public CotOperation(
        ICot executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Котангенс")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ICot executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}