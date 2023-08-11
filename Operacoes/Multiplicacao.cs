namespace CSProjects;

public class Multiplicacao : OperationModel
{
    public Multiplicacao(){}

    public override void operationInt(int a, int b){
        Console.WriteLine($"A multiplicação dos números é: {a * b}");
        Console.WriteLine("_______________________________________");
    }

    public override void operationDouble(double a, double b){
        Console.WriteLine($"A multiplicação dos números é: {a * b:N2}");
        Console.WriteLine("_______________________________________");
    }
}
