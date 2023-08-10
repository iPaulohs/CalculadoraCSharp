
namespace CSProjects;
public class Controller
{

    public Controller() { }

    public void questions()
    {
        Console.WriteLine("Escolha uma operação a ser realizada:\n1 - Adicao\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");

        switchMethod();
    }
    public void switchMethod()
    {
        double resposta = int.Parse(Console.ReadLine());

        bool ativo = true;

        while (ativo)
        {
            switch (resposta)
            {
                case 1:
                    Soma soma = new Soma();
                    soma.questions();
                    questions();
                    break;
                case 2:
                    Subtracao subtracao = new Subtracao();
                    subtracao.questions();
                    questions();
                    break;
                case 3:
                    Multiplicacao multiplicacao = new Multiplicacao();
                    multiplicacao.questions();
                    questions();
                    break;
                case 4:
                    Divisao divisao = new Divisao();
                    divisao.questions();
                    questions();
                    break;
                default:
                    Console.WriteLine("Digite um número válido!");
                    questions();
                    break;

            }
        };

    }
}
