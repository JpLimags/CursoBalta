namespace AddValDates;

public class AddValDates
{

    static void Main()
    {

        var data = DateTime.Now;
        Console.WriteLine(data);
        
        
        //Abaixo estamos adicionando valores na data apartir dos métodos AddDays,AddMonths, AddYears para datas
        Console.WriteLine(data.AddDays(5));
        Console.WriteLine(data.AddMonths(2));
        Console.WriteLine(data.AddYears(10));
        
        //Por estar dentro de datas também é possível adicionar valores a horas, minutos e segundos
    }
}