namespace CSProjects;

public class Divisao : OperationModel
{
    public Divisao(){}

    public void operationInt(int a, int b)
    {
        Console.WriteLine($"a divisão dos números é {a / b} e o resto é {a % b}");
    }
    
    public void operationDouble(double a, double b)
    {
        Console.WriteLine($"a divisão dos números é {a / b} e o resto é {a % b}");
    }
}
