using System;
using System.Collections.Generic;

class Ex7{
    public static void Programa(){
        Console.WriteLine("Digite o número de alunos: ");
        int numeroAlunos = int.Parse(Console.ReadLine());

        List<double> notas = new List<double>();

        for (int i = 0; i < numeroAlunos; i++){
            Console.WriteLine("Digite a nota do aluno {i + 1}: ");
            double nota = double.Parse(Console.ReadLine());
            notas.Add(nota);
        }

        double mediaAprovados = CalcularMediaAprovados(notas);

        if (mediaAprovados > 0)
        {
            Console.WriteLine("A média das notas dos alunos aprovados é: {mediaAprovados:F2}");
        }
        else
        {
            Console.WriteLine("Nenhum aluno aprovado.");
        }
    }

    static double CalcularMediaAprovados(List<double> notas)
    {
        double soma = 0;
        int countAprovados = 0;

        foreach (double nota in notas)
        {
            if (nota >= 6)
            {
                soma += nota;
                countAprovados++;
            }
        }

        return countAprovados > 0 ? soma / countAprovados : 0;
    }
}
