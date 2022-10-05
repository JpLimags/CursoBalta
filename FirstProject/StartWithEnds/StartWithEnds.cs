namespace StartWithEnds;

public class StartWithEnds
{

    static void Main()
    {

        var texto = "Ola mundo, como estão?";

        Console.WriteLine(texto.StartsWith("Ola"));
        Console.WriteLine(texto.EndsWith("estão")); //False
        Console.WriteLine(texto.EndsWith("?")); //True
    }
}