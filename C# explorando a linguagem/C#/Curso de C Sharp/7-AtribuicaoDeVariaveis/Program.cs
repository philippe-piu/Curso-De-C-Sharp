using System;
//Atribuição de Variáveis
class Programa
{
    static void Main(string[] args)
    {
        int idade = 30;
        //idade ana ta pegando o valor de idade definido como 30
        int idadeAna = idade;

        Console.WriteLine("Projeto 7 - Atribuição de variáveis");
        //Imprimindo o primeiro valor de idadeAna
        Console.WriteLine("Idade de Ana é "+idadeAna);

        //Aqui to alterando a variavel idade de 30 para 25
        idade= 25;
        //Imprimindo o novo valor de idade
        Console.Write("Ana mentiu a idade é "+idade+ " na verdade\n");

        Console.WriteLine("Aperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}