using System;

class Ex1{
    // Função que calcula a base 'a' elevada ao expoente 'b'
    public static double Potencia(int a, int b){
        double resultado = 1;
        for (int i = 1; i <= b; i++) // Repete a multiplicação 'b' vezes
        resultado *= a;
        return resultado;
    }

    public static void Programa(){
        Console.WriteLine("Informe a base:");
        int bas = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe o expoente:");
        int exp = int.Parse(Console.ReadLine());

        double pot = Potencia(bas, exp);
        Console.WriteLine("Resultado: " + pot);
    }
}
