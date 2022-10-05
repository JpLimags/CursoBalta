namespace Timezones;

public class TimeZones
{

    static void Main()
    {
        //No exemplo abaixo temos o horário universal
        var dateTime = DateTime.UtcNow;
        
        
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(dateTime.ToLocalTime());
        
        Console.WriteLine(dateTime);

        //Aqui pegamos as informações do usuário sobre a posição que neste caso é a Austrália
        var timezoneAus = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        Console.WriteLine(timezoneAus);
        
        //Aqui estamos convertendo para o hórario da Austrália
        
        var horaAus = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAus);
        Console.WriteLine(horaAus);
        
        //Lista todos o stimezones existentes no sistema
        var timezones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in timezones)
        {
         
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
            Console.WriteLine("--------------");
        }
    }
}