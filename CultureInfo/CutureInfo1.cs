namespace CultureInfo;

using System.Globalization;

public class CutureInfo1
{

    static void Main()
    {
        var pt = new CultureInfo("pt-Br");
        var pt2 = new CultureInfo("pt-PT");
        
        //Vai pegar a culturaque já está configurada na máquina
        
        var atualCuture = CultureInfo.CurrentCulture;
        
        //var br = new CutureInfo("pt-BR");
        
        Console.WriteLine(DateTime.Now);
        
        Console.WriteLine(DateTime.Now.ToString("D", pt));
        Console.WriteLine(DateTime.Now.ToString("D", pt2));
    }
}