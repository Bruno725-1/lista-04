using System;
class Ex6{
    public static void Calcular(double a, double b){
        double ns=(a*b)/100;
    }
    public static void Programa(){
        Console.WriteLine("Informe o salário");
        double salario=double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o índice de reajuste em porcentagem");
        double reajuste=double.Parse(Console.ReadLine());
        double novoSalario=Calcular(salario, reajuste);
    }
}