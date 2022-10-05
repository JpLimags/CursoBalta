namespace Indice;

public class Indice
{
    
    static void Main()
    {

        var text = "Ola mundo";
        Console.WriteLine(text.IndexOf("o", StringComparison.OrdinalIgnoreCase)); //0
        Console.WriteLine(text.LastIndexOf("o", StringComparison.OrdinalIgnoreCase));//8
    }
}