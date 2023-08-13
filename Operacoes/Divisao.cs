namespace CSProjects;

public class Divisao : OperationModel
{
    public override void operationInt(int a, int b)
    {
        Console.WriteLine($"A divisão dos números é {a / b} e o resto é {a % b}");
        base.operationInt(a, b);
    }
    
    public override void operationDouble(double a, double b)
    {
        Console.WriteLine($"A divisão dos números é {a / b} e o resto é {a % b}");
        base.operationDouble(a, b);
    }
}
