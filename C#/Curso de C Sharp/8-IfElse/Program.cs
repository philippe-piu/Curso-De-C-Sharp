using System;
//If,  Else 
//Se  Se não
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 8 - Consicionais IF ELSE\n");
        int idade = 17;

        if (idade >= 18)
        {
            Console.WriteLine("Maior de idade");
            Console.WriteLine("Você Pode entrar na Festa");
        }
        else
        {
            Console.WriteLine("Menor de idade");
            Console.WriteLine("Você não pode entrar na festa");
        }

        Console.WriteLine("Aperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}
