using System;
class Ex4{
    public static double Mdc(int a, int b){
        double mdc=0;
        while(b!=0){
            int r=a%b;
            a=b;
            b=r;
        }
        mdc = a;
        return mdc;
    }
    public static void Programa(){
        Console.WriteLine("Digite dois números");
        int x=int.Parse(Console.ReadLine());
        int y=int.Parse(Console.ReadLine());
        double divisor=Mdc(x, y);
        Console.WriteLine("MDC: "+divisor);
    }
}