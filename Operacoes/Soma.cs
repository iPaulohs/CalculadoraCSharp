namespace CSProjects;

public class Soma
{
    public void questions()
    {
        Console.WriteLine("Digite o primeiro número");
        double n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        double n2 = double.Parse(Console.ReadLine());

        sum(n1, n2);
    }
    private void sum(double a, double b)
    {
        Console.WriteLine($"O resultado da soma é: {a + b}");
    }
}
