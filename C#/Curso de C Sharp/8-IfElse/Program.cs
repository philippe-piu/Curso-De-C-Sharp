using System;
//If,  Else 
//Se  Se não
class Programa
{
    static void Main(string[] args)
    {
        int numero = 10;
        int i;
        int multiplicacao;

        Console.WriteLine("Tabuada do " + numero);

        for(i = 1; i <= 10; i++)
        {
            multiplicacao = numero * i;
            Console.WriteLine(+numero +" x " +i +" = "+multiplicacao);
        }
        Console.WriteLine("Aperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}
