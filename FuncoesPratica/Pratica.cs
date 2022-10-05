namespace FuncoesPratica;

public class Pratica
{
    static void Main()
    {
        string nome = "Jp";
        string sobrenome = "Lima";
        
        //MeuMetodo();
        var nomeCompleto = RetornaNome(nome, sobrenome);
        Console.WriteLine(nomeCompleto);
    }

    static void MeuMetodo()
    {
        
        Console.WriteLine("My method is like !");
    }

    static string RetornaNome(string nome, string sobrenome)
    {
        return nome + " " + sobrenome;
    }
}