namespace CustomException;

public class CustomException
{


    static void Main()
    {
        
        var arr = new int[3];

        try
        {

            /*for (int i = 0; i < 5; i++)
            {
                
                //System.IndexOutOfRangeException
                Console.WriteLine(arr[i]);
            }*/

            Cadastrar("");
        }
        catch (IndexOutOfRangeException e1)
        {

            Console.WriteLine("Não foi posssivel encontrar o indice");


            //Tem a função de capturar a exceção
            Console.WriteLine(e1.InnerException);

            //Mostra a mensagem do erro 
            Console.WriteLine(e1.Message);


        }

        catch (MyException e2)
        {

            Console.WriteLine("Falha ao cadastrar o texto");


            //Tem a função de capturar a exceção
            Console.WriteLine(e2.InnerException);

            //Mostra a mensagem do erro 
            Console.WriteLine(e2.Message);

        }

        catch (Exception e3)
        {

            Console.WriteLine("Algo deu errado!");


            //Tem a função de capturar a exceção
            Console.WriteLine(e3.InnerException);

            //Mostra a mensagem do erro 
            Console.WriteLine(e3.Message);
            // ??QUE
        }

        finally
        {
            Console.WriteLine("A nossa execução chegou ao fim !");
        }
    }

    static void Cadastrar(string texto)
    {
        if (string.IsNullOrEmpty(texto)) ;
        throw new MyException(DateTime.Now);
    }
    
    
    //Criando a classe que irá servir como exceção cistomizada
    public class MyException : Exception
    {

        public MyException(DateTime date)
        {
            QuandoAconteceu = date;
        }
        public DateTime QuandoAconteceu { get; set; }
    }
}