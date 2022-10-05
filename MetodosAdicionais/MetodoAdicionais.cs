namespace MetodosAdicionais;

public class MetodoAdicionais
{
    static void Main()
    {
        var text = "Ola mundo, aqui estou";
        Console.WriteLine(text.ToLower());
        Console.WriteLine(text.ToUpper());
        Console.WriteLine(text.Insert(10, "Eita"));
        Console.WriteLine(text.Remove(9));
    }
}        