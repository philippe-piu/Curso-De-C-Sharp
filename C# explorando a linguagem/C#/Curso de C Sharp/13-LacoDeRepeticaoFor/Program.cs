using System;
//Laçõ Repetição For
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Laço de repetição For\n");

        double investimento = 1000;
        //rendimento de 0,5% (0.005) ao mês

        for (int i = 1; i<= 12; i++)
        {
            investimento += investimento * 0.005;
            Console.WriteLine("No mês " +i+ " você tem R$" + investimento);
        }
      

        Console.WriteLine("\nAperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}

