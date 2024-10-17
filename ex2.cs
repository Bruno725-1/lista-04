using System.Runtime.InteropServices;

class Ex2{
    public static void Pesquisa(){
        double salario=0, media=0, filhos=0, soma=0, habitantes=0, soma_salario=0, soma_filhos=0;
        while(salario>=0){
            Console.WriteLine("Informe o salário do habitante, número negativo encerra o programa");
            salario=double.Parse(Console.ReadLine());
            if(salario<0)
            break;
            soma_salario=soma_salario+salario;
            habitantes++;
            Console.WriteLine("Informe o número de filhos do cidadão");
            filhos=double.Parse(Console.ReadLine());
            soma_filhos=filhos+soma_filhos;
        }
        habitantes=habitantes+soma_filhos;
        media=soma_salario/habitantes;
        Console.WriteLine("Média do salário dos habitantes: "+media);
    }
}