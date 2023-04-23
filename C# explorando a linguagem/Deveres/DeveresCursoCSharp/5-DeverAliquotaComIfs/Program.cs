using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.00;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("Seu salario é " + salario);
            Console.WriteLine("IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");
        }
        else if (salario >= 2800.1 && salario <= 3751.0)
        {
            Console.WriteLine("Seu salario é " + salario);
            Console.WriteLine("IR é de 15% e pode deduzir R$ 350");
        }
        else if (salario >= 3751.01 && salario <= 4664.00)
        {
            Console.WriteLine("Seu salario é " + salario);
            Console.WriteLine("IR é de 22.5% e pode deduzir R$ 636.");
        }

        Console.WriteLine("Tecle enter para fechar....");
        Console.ReadLine();
    }
}

/* 5 - O João gostaria de criar um programa sobre Imposto de Renda (IR) e verificou as regras de alíquota. 
Ele descobriu no site da receita o seguinte:
De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142;
De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350;
De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636.
 */