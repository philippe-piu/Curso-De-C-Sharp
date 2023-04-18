using System;

/*2 - Criar Calculadora Simples*/
class Programa
{
    static void Main(string[] args)
    {
        int a = 6;
        int b = 5;
        int resultado;

        Console.WriteLine("Calculadora Simples\n");

        resultado = a + b;
        Console.WriteLine("A Soma de 5 + 6 = "+resultado);
        resultado = a - b;
        Console.WriteLine("A Subtração de 5 - 6 = " +resultado);
        resultado = a * b;
        Console.WriteLine("A Multiplicação de 5 x 6 = " +resultado);
        resultado = a /+ b;
        Console.WriteLine("A Divisão de 5 / 6 = " +resultado);

        Console.ReadLine();
    }
}