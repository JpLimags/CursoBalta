namespace CompareTo;

public class CompareTo
{

    static void Main()
    {

        var texto = "Esse é um teste";
        Console.WriteLine(texto.Contains("teste"));
        
        /*No caso abaixo o case senditive é ignorado*/
        Console.WriteLine("Teste", StringComparison.OrdinalIgnoreCase);
    }
}   
