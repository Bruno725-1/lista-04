using System;
using System.Globalization;
class Ex5{
    public static bool Verificar(int n){
        return (n>=0);
    }
    public static void Programa(){
        int num=0;
        do{
        Console.WriteLine("Digite um número, 0 encerra o programa");
        num=int.Parse(Console.ReadLine());
        if (num != 0) {
            bool isPositivo = Verificar(num);
            if (isPositivo) {
                Console.WriteLine("O número "+num+" é positivo.");
            } else {
                Console.WriteLine("O número "+num+" é negativo.");
            }
        }
        }
        while(num!=0);
    }
}