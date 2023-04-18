using System;
//Armazenamento de texto
class Programa
{
    static void Main(string[] args)
    {
        //string armazena palavras
        //Uma string é armazenada por aspas duplas"
        string primeiraFrase = "O que tiver que ser será meu ta escrito nas estrelas vai reclamar com Deus";
        Console.WriteLine("Executando o projeto 6 - Textos\n");
        Console.Write(primeiraFrase);

        primeiraFrase = "Ta chovendo hoje dia ";
        Console.WriteLine("\n" + primeiraFrase + 18 + " Abril " + 2023);
        //Para imprimir uma lista usando um string utilize o @ como no exemplo abaixo
        Console.WriteLine("Imprir Listas\n");
        string lista = @"Alfabeto:
A
B
C
D
...";
        Console.WriteLine(lista);

        Console.WriteLine("Aperte a tecla enter para fechar......\n");
        Console.ReadLine();
    }
}