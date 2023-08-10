namespace CSProjects;
public class Soma
{
    public void questions()
    {
        Console.WriteLine("Digite o primeiro número");
        string n1 = Console.ReadLine();
        Console.WriteLine("Digite o segundo número: ");
        string n2 = Console.ReadLine();

        if(int.TryParse(n1, out int intNum1) && int.TryParse(n2, out int intNum2)){
            sum(intNum1, intNum2);
        } 

        if(double.TryParse(n1, out double doubleNum1) && double.TryParse(n2, out double doubleNum2)){
            sum(doubleNum1, doubleNum2);
        }
    }

    public void sum(int a, int b){
        Console.WriteLine($"A soma dos números é: {a + b}");
    }

    public void sum(double a, double b){
        Console.WriteLine($"A soma dos números é: {a + b}");
    }
}
