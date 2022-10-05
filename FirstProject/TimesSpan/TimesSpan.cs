namespace TimesSpan;

public class TimesSpan
{

    static void Main()
    {
        
        // É uma unidade de medidade utlizado para trabalharmos com hora
        var timeSpan = new TimeSpan();
        Console.WriteLine(timeSpan);

        //Aqui ele irá tratar o primeiro valor em nano segundo
        var timeNano = new TimeSpan(1);
        Console.WriteLine(timeNano);

        var horaMinutoSegundo = new TimeSpan(12,8,2);
        Console.WriteLine(horaMinutoSegundo);
        
        var diaHoraMinutoSegundo = new TimeSpan(2,6,8,2);
        Console.WriteLine(diaHoraMinutoSegundo);
        
        var diaHoraMinutoSegundoMilisegundo = new TimeSpan(10,2,12,8,2);
        Console.WriteLine(diaHoraMinutoSegundoMilisegundo);

    }
}