namespace CSProjects;

public class Subtracao : OperationModel
{
    public override void operationInt(int a, int b){
        Console.WriteLine($"A subtração dos números é: {a - b}");
        Console.WriteLine("_______________________________________");
    }

    public override void operationDouble(double a, double b){
        Console.WriteLine($"A subtração dos números é: {a - b:N2}");
        Console.WriteLine("_______________________________________");
    }
}
