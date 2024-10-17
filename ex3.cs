using System.Security.Cryptography.X509Certificates;

class Ex3{
    public static void Ler(){
        Console.WriteLine("Informe a medida dos três lados");
        double x=double.Parse(Console.ReadLine());
        double y=double.Parse(Console.ReadLine());
        double z=double.Parse(Console.ReadLine());
        if(x<y+z && y<x+z && z<x+y){
            if(x==y && y==z)
            Console.WriteLine("Triângulo equilátero");
            else if(x==y ||y==z || x==z)
            Console.WriteLine("Isóceles");
            else Console.WriteLine("Qualquer");
        }
        else Console.WriteLine("Não é um triângulo");
    }
    public static void Programa(){
        int opcao;
        Console.WriteLine("Digite 1 para ler um triângulo ou 0 para finalizar o programa");
        opcao=int.Parse(Console.ReadLine());
        switch(opcao){
            case 1:
            Ler();
            break;
            case 0:
            break;
        }
    }
}