namespace CSProjects;
public class Soma : OperationModel
{
    public override void operationInt(int a, int b)
    {
        Console.WriteLine($"A soma dos números é: {a + b}");
        base.operationInt(a, b);
    }

    public override void operationDouble(double a, double b)
    {
        Console.WriteLine($"A soma dos números é: {a + b:N2}");
        base.operationDouble(a, b);
    }
}
