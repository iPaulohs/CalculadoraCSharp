namespace CSProjects;

public class OperationModel
{

    public void questions()
    {
        Console.WriteLine("Digite o primeiro número");
        string n1 = Console.ReadLine();
        Console.WriteLine("Digite o segundo número: ");
        string n2 = Console.ReadLine();

        if(int.TryParse(n1, out int intNum1) && int.TryParse(n2, out int intNum2)){
            operationInt(intNum1, intNum2);
        } 

        if(double.TryParse(n1, out double doubleNum1) && double.TryParse(n2, out double doubleNum2)){
            operationDouble(doubleNum1, doubleNum2);
        }
    }
        public void operationInt(int a, int b)
        {
            
        }
    
        public void operationDouble(double a, double b){}
}