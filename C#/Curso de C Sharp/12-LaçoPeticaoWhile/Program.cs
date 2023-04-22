using System;
//Laçõ Repetição While
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 12 - Laço de repetição While\n");

        int mes = 1;
        double investimento = 1000;
        //rendimento de 0,5% (0.005) ao mês

        // investimento += investimento * 0.005;
        //Console.WriteLine(investimento);

        while(mes <= 12){
            investimento += investimento * 0.005;
            Console.WriteLine("No mês "+mes+ " você tem R$" + investimento );
            mes++;
        }

        Console.WriteLine("\nAperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}
