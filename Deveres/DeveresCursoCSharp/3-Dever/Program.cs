using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 1270.50;
        int valor;
        
        //Fazendo a Conversão de double para inteiro
        valor= (int)salario;

        //Fazendo a impressão da variavel valor
        Console.WriteLine("Parte do 1 ao dever 5");
        Console.WriteLine("Valor "+valor);

        //Parte 6 do dever
        double valor1 = 0.2;
        double valor2 = 0.2;
        double total = valor1 + valor2;
        Console.WriteLine("\nParte 6");
        Console.WriteLine("Soma de 0.2 + 0.2 = " + total);

        //Parte 7 ao 9 do dever
        float pontoFlutuante = 3.14f;
        Console.WriteLine("\nParte 7 ao 9");
        Console.WriteLine("Ponto Flutuante Float "+pontoFlutuante);

        Console.WriteLine("\nAperte a tecla enter para fechar...\n");
        Console.ReadLine();
    }
}

/*
 * 1) Crie um projeto, no curso escolhemos o nome 
 * 2) Escreva o seguinte código: 
 * class Programa
{
    static void Main(string[] args)
    {
        double salario = 120.50;
        int valor = salario;
    }
}
*3) Existe uma forma de fazer com que esse código compile. Para isso usaremos o que chamamos de casting. 
Modifique seu código e adicione (int) antes da variável salario:
*4) "Printe" a variável valor no console, para isso, adicione:
*5) Saída deve ser A saída será 1270.
*6) No momento, nossa variável salario é do tipo double, será que essa é a melhor escolha? Teste o seguinte:
Escreva três variáveis do tipo double como feito abaixo. A última variável (total) receberá a somatória das 
outras duas, observe:
*7) Vamos testar também o tipo float, para isso escreva a variável pontoFlutuante do tipo float.
*8) Informe ao C# que o valor 3.14 é um float colocando "f" ao final do número.
*9) Imprimir a Variavel flutuante float
 */