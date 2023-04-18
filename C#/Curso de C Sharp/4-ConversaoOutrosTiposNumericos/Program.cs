using System;
//Conversão e outros tipos numéricos

class Programa
{
    static void Main(string[] args)
    {

        double salario;
        //Long é uma variavel de 64 bits
        long x;
        //Short é uma variavel de 16 bits
        short y;
        float altura;
        altura = 1.62f;
        x = 2000000000000000000;
        y = 15000;
        salario = 3000.15;

        int salarioInteiro;
        //Covertendo salario para inteiro colocando o int antes da variavel ele ignora os valores após a virgula e imprime o valor inteiro
        salarioInteiro = (int)salario;

        //Imprimindo informações passadas 
        Console.WriteLine("Informações Passadas das Variaveis ");
        Console.WriteLine("Double " + salario);
        Console.WriteLine("Conversão de Double para um inteiro " + salarioInteiro);
        Console.WriteLine("Long " + x);
        Console.WriteLine("Short " + y);
        Console.WriteLine("Float " + altura);
        Console.WriteLine("\nAperte a tecla enter para fechar....");
        Console.ReadLine();
    }
}