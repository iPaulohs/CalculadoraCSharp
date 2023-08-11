namespace CSProjects;

public class Divisao : OperationModel
{
    public Divisao(){}

    public override void operationInt(int a, int b)
    {
        Console.WriteLine($"A divisão dos números é {a / b} e o resto é {a % b}");
        Console.WriteLine("_______________________________________");
    }
    
    public override void operationDouble(double a, double b)
    {
        Console.WriteLine($"A divisão dos números é {a / b} e o resto é {a % b}");
        Console.WriteLine("_______________________________________");
    }
}
