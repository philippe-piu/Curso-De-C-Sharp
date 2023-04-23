using System;
//Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.
class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("Multiplos de 3\n");
        for(int i = 0; i < 100; i++)
        {
            if(i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("\nAperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}