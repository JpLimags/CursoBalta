using System.Globalization;

namespace FormatMoeda;

public class FormatMoeda
{
    static void Main()
    {

        decimal valor = 10.50m;

        var culture = CultureInfo.CreateSpecificCulture("pt-BR");
        Console.WriteLine(valor.ToString("C", culture));
        
        /*Além do formatador C(currenty), temos também o P(adiciona o simbolo de porcetagem, e o N que coloca o número
         mas sem a formatação de moeda),*/ 
    }
}