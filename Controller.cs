namespace CSProjects;
public class Controller
{
    private bool ativo = true;

    public void questions()
    {
        Console.WriteLine("Escolha uma operação a ser realizada:\n1 - Adicao\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Sair");

        switchMethod();
    }

    public void switchMethod()
    {
        int resposta = int.Parse(Console.ReadLine());

        while (ativo)
        {
            switch (resposta)
            {
                case 1:
                    Soma soma = new Soma();
                    soma.questions();
                    break;
                case 2:
                    Subtracao subtracao = new Subtracao();
                    subtracao.questions();
                    break;
                case 3:
                    Multiplicacao multiplicacao = new Multiplicacao();
                    multiplicacao.questions();
                    break;
                case 4:
                    Divisao divisao = new Divisao();
                    divisao.questions();
                    break;
                case 5:
                    Console.WriteLine("Até à próxima!");
                    ativo = false;
                    break;
            }
            if (ativo)
            {
                questions();
            }
        }
    }
}
