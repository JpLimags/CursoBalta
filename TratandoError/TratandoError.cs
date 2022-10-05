namespace TratandoError;

public class TratandoError
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
        catch(IndexOutOfRangeException e1)
        {
            
            Console.WriteLine("Não foi posssivel encontrar o indice");
            
            
            //Tem a função de capturar a exceção
            Console.WriteLine(e1.InnerException);
            
            //Mostra a mensagem do erro 
            Console.WriteLine(e1.Message);
            
        
        }
        
        catch(Exception e2)
        {
            
            Console.WriteLine("Algo deu errado!");
            
            
            //Tem a função de capturar a exceção
            Console.WriteLine(e2.InnerException);
            
            //Mostra a mensagem do erro 
            Console.WriteLine(e2.Message);

        }
    }
}