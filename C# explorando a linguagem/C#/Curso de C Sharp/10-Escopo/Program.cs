using System;
//Escopo
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 10 - Escopo \n");

        int idade = 18;
        bool responsavel = true;
        //Como eu declarei ele aqui ele po ser usado por todo o codigo principal
        string texto;

        if(responsavel = true)
        {
            texto = "Menor de idade mais acompanhado com um responsavel";
        }
        else
        {
            texto = "Maior de idade não precisa de responsavel";
        }

        if (idade < 18 && responsavel == true)
        {
            Console.WriteLine(texto);
            Console.WriteLine("Você pode entrar na festa");
        }
        else
        {
            Console.WriteLine(texto);
            Console.WriteLine("Você Pode entrar na Festa");
        }

        Console.WriteLine("Aperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}