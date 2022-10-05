namespace Swich;

public class Switch
{
    /*Esse exemplo foi criado por mim para exemplificar */


    static void Main()
    {
        
        Console.WriteLine("Qual sua idade:\n");
        int idade = int.Parse(Console.ReadLine());
    
        VerificadorIdade(idade);
    }

    static void VerificadorIdade(int idade)
    {

        switch (idade)
        {   
            case < 12:
            {
                Console.WriteLine("Você é uma criança !");
                break;
            }
            case < 18:
            {
                Console.WriteLine("Você é de menor !");
                break;
            }
            case >= 18:
            {
                Console.WriteLine("Você é maior de idade !");
                break;
            }

        }
    }
}