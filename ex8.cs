using System;
using System.Globalization;
class Ex8{
    public static void Programa(){
        Console.WriteLine("Digite um número");
        int numero=int.Parse(Console.ReadLine());
        bool resultado=Verificar(numero);
        if(resultado)
        Console.WriteLine("O número "+numero+" é primo");
        else
        Console.WriteLine("O número "+numero+" não é primo");
    }
    public static bool Verificar(int num){
        // Verifica se há divisores entre 2 e a raiz quadrada de 'numero'
        for(int i = 2; i<=Math.Sqrt(num); i++){
            if(num%i==0)
            return false;
        }
        return true;
    }
}