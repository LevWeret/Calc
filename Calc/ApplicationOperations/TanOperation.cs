namespace CalculatorCsharp;

public sealed class TanOperation : DoubleMathOperation
{
    public TanOperation(
        ITan executor,
        IOperationArgsProvider<OneStandartArgs> args)
        : base("Тангенс")
    {
        this.executor = executor;
        this.args = args;
    }

    private readonly ITan executor;
    private readonly IOperationArgsProvider<OneStandartArgs> args;

    public override double Execute()
    {
        OneStandartArgs args = this.args.Get();
        return executor.Invoke(args.Number);
    }
}