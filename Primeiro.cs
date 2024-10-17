class Primeiro{
    public static double Fatorial(int n){
        double f=1;
        for(int x=1; x<=n; x++)
        f*=x;
        return f;
    }
    public static void Rodar(){
        Console.WriteLine("Digite um número");
        int num=int.Parse(Console.ReadLine());
        double fat = Fatorial(num);
        Console.WriteLine("Fatorial é: "+fat);
    }
}