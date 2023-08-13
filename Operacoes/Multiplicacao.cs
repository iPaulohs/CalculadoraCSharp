namespace CSProjects;

public class Multiplicacao : OperationModel
{
    public override void operationInt(int a, int b)
    {
        Console.WriteLine($"A multiplicação dos números é: {a * b}");
        base.operationInt(a, b);
    }

    public override void operationDouble(double a, double b)
    {
        Console.WriteLine($"A multiplicação dos números é: {a * b:N2}");
        base.operationDouble(a, b);
    }
}
