using System;

class Ex10{
    public static void Programa(){
        Console.WriteLine("Informe a média final do aluno:");
        double mediaFinal = double.Parse(Console.ReadLine());

        char conceito = Conceituar(mediaFinal);
        Console.WriteLine($"O conceito do aluno é: {conceito}");
    }

    public static char Conceituar(double media){
        if (media >= 0 && media <= 4.9)
        {
            return 'D';
        }
        else if (media >= 5 && media <= 6.9)
        {
            return 'C';
        }
        else if (media >= 7 && media <= 8.9)
        {
            return 'B';
        }
        else if (media >= 9 && media <= 10)
        {
            return 'A';
        }
        else{
            throw new ArgumentOutOfRangeException("A média deve estar entre 0 e 10.");
        }
    }
}
