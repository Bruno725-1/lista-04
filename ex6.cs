using System;
class Ex6{
    public static void Calcular(double salario, double indiceReajuste, out double novoSalario){
        double reajuste=(salario*indiceReajuste)/100;
        novoSalario=salario+reajuste;
    }
    public static void Programa(){
        Console.WriteLine("Informe o salário");
        double salario=double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o índice de reajuste em porcentagem");
        double indiceReajuste=double.Parse(Console.ReadLine());
        double novoSalario;
        Calcular(salario, indiceReajuste, out novoSalario);
        Console.WriteLine("Salário com reajuste: "+novoSalario);
    }
}