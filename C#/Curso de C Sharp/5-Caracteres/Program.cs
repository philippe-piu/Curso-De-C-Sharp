using System;
//Armazenamento de Caracteres
class Programa
{
    static void Main(string[] args)
    {
        //Char armazena um caracter
        //Um caracter de char é armazenado por aspas simples
        char letra = 'a'; 
        
        Console.WriteLine("Executando o projeto 5 - Caracteres");
        Console.WriteLine(letra);
        //Convertendo para um caracter o número 65 vale como A
        letra = (char)65;
        Console.WriteLine(letra);
        //Convertendo para um caracter o número 66 vale como B
        letra = (char)(65 + 1);
        Console.WriteLine(letra);
        //Convertendo para um caracter o número 87 vale como W
        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        Console.WriteLine("\nAperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}
