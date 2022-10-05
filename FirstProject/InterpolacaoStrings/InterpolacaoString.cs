namespace InterpolacaoStrings;

public class InterpolacaoString
{

    static void Main()
    {
        var price = 5.7;
        //var texto = "O preço do produto é " + price;


        var texto = string.Format("O preço do produto é {0} apenas na promocao", price);
        Console.WriteLine(texto);
    }
}    

