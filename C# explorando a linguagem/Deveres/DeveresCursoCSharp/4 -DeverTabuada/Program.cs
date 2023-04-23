using System;
/*Faça a Tabuada do 2.
 O programa imprimirá: 2x1=2, 2x2=4, 2x3=6, ..., 2x10=20
*/
class Programa
{
    static void Main(string[] args)
    {
        int numero = 2;
        int i;
        int multiplicacao;

        Console.WriteLine("Tabuada do " + numero);

        for (i = 1; i <= 10; i++)
        {
            multiplicacao = numero * i;
            Console.WriteLine(numero + " x " + i + " = " + multiplicacao);
        }
        Console.WriteLine("Aperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}