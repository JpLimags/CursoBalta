namespace CompDates;

public class CompDates
{

    static void Main()
    {

        var data = DateTime.Now;
        
        /*
         
         Não vai funcionar !!!
         
        if (data == DateTime.Now)
        {
        
            Console.WriteLine("Is equal");
        }
        */
        
        //Para funcionar é necessário adicionarmos o.Date no final]
        
        //Os operadores >=, <=, <, >, !=
        
        if (data.Date == DateTime.Now.Date)
        {
        
            Console.WriteLine("Is equal");
        }
        
    }
}