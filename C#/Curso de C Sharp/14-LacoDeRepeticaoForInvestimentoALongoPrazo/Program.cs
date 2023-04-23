using System;
//Laço de Repetição For Investimento a Longo Prazo
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 13 - Laço de repetição For Investimento a Longo Prazo\n");

        double fatordeRendimento = 1.005;
        double investimento = 1000;

        //Anos
        for (int i = 1; i <= 5; i++)
        {
            //Mes
            for (int j = 1; j <= 12; j++)
            {
                investimento *= fatordeRendimento;
            }
            fatordeRendimento +=  0.001;
        }

        
        Console.WriteLine("Depois de 5 anos você terá R$" + investimento);

        Console.WriteLine("\nAperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}
