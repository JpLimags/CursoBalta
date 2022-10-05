namespace Manipulando_strings;

public class ManipulandoStrings
{

    static void Main()
    {

        var texto = "Este texto é um teste";
        Console.WriteLine(texto.Replace("é", "is"));

        var divisao = texto.Split(" ");
        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        Console.WriteLine(divisao[2]);
        Console.WriteLine(divisao[3]);
        Console.WriteLine(divisao[4]);
        
        /*Já utilizado anteriormente no curso tem a função de dividir uma string maior em substring menores, dentro de um intervalo*/
        var resultado = texto.Substring(5, 5);
        Console.WriteLine(resultado);
        
        //Serve para tirar espaços desnecessários do inicio e do final
        Console.WriteLine((texto.Trim()));
    }
}