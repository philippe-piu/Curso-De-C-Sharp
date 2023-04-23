using System;
//Booleanas com condicionais 
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 9 - Booleano TRUE FALSE com Condicionais\n");
        int idade = 18;
        bool responsavel = true;

        if (idade < 18 && responsavel == true)
        {
            Console.WriteLine("Menor de idade mais acompanhado com um responsavel");
            Console.WriteLine("Você pode entrar na festa");
        }
        else
        {
            Console.WriteLine("Maior de idade não precisa de responsavel");
            Console.WriteLine("Você Pode entrar na Festa");
        }
        Console.WriteLine("Aperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}
