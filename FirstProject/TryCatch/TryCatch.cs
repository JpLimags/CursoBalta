namespace TryCatch;

public class TryCatch
{

    static void Main()
    {
        var arr = new int[3];

        try
        {
    
            for (int i = 0; i < 5; i++)
            {
                
                //System.IndexOutOfRangeException
                Console.WriteLine(arr[i]);
            }
        }
        catch(Exception e1)
        {
            
            Console.WriteLine("Deu merda menor !");
            
            /*
            Tem a função de capturar a exceção
            Console.WriteLine(e1.InnerException);
            
            Mostra a mensagem do erro 
            Console.WriteLine(e1.Message);
            */
        
        }
    }
}