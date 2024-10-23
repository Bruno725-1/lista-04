using System;
class Ex9{
    public static void Calcular(int horaInicio, int minutoInicio, int horaFim, int minutoFim, ref int duracaoHoras, ref int duracaoMinutos){
        //Converter tudo para minutos para facilitar os cálculos
        int inicioMinutos = (horaInicio*60) + minutoInicio;
        int fimMinutos = (horaFim*60) + minutoFim;
        if(fimMinutos<=inicioMinutos)
        fimMinutos +=24*60;
        //cálculo da diferença em minutos
        int duracaoTotalMinutos = fimMinutos - inicioMinutos;
        //Converter de volta para horas e minutos
        duracaoHoras = duracaoTotalMinutos/60;
        duracaoMinutos=duracaoTotalMinutos%60;
    }
    public static void Programa(){
        Console.WriteLine("Informe a ora de início e tecle enter, em seguida, informe os minutos de início e tecle enter");
        int horaInicio=int.Parse(Console.ReadLine());
        int minutoInicio=int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a hora de término e tecle enter, em seguida, informe os minutos de término e tecle enter");
        int horaFim=int.Parse(Console.ReadLine());
        int minutoFim=int.Parse(Console.ReadLine());
        int duracaoHoras=0, duracaoMinutos=0;
        Calcular(horaInicio, minutoInicio, horaFim, minutoFim, ref duracaoHoras, ref duracaoMinutos);
        Console.WriteLine("Duração do jogo: {0} horas e {1} minutos",duracaoHoras, duracaoMinutos);
    }
}