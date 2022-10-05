namespace Equals;

public class Equals
{

    static void Main()
    {
        var texto = "Ola mundo";
        
        Console.WriteLine(texto.Equals("Ola mundo"));
        Console.WriteLine(texto.Equals("Este "));
    }
}