
namespace CSProjects;
public class Controller
{

    public Controller(){}
   public void switchMethod()
   {
        Console.WriteLine("Bem-vindo à calculadora do Infnet. Escolha uma operação a ser realizada:\n1 - Adicao\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");

        double resposta = int.Parse(Console.ReadLine());

        bool ativo = true;

        do
        {
            switch(resposta)
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

            }
        }while(ativo);

   }
}
