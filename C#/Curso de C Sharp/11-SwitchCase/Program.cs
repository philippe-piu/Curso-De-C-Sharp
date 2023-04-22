using System;
using System.Linq.Expressions;
//Switch Case

/*Exemplo simples
 * O código que será executado, que no nosso caso será a impressão do nome do mês, 
 * será o código em que a condição for verdadeira:
 */
class Programa
{
    static void Main(string[] args)
    {
        int opcao = 0;

        Console.WriteLine("Esolha um número de 1 a 12 \n");

        //Faz a leitura de valor informado pelo o usuario
        opcao = int.Parse(Console.ReadLine());

        Console.WriteLine("Número escolhido é: " + opcao);
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Janeiro");
                break;
            case 2:
                Console.WriteLine("Fevereiro");
                break;
            case 3:
                Console.WriteLine("Março");
                break;
            case 4:
                Console.WriteLine("Abril");
                break;
            case 5:
                Console.WriteLine("Maio");
                break;
            case 6:
                Console.WriteLine("Junho");
                break;
            case 7:
                Console.WriteLine("Julho");
                break;
            case 8:
                Console.WriteLine("Agosto");
                break;
            case 9:
                Console.WriteLine("Setembro");
                break;
            case 10:
                Console.WriteLine("Outubro");
                break;
            case 11:
                Console.WriteLine("Novembro");
                break;
            case 12:
                Console.WriteLine("Dezembro");
                break;
            default:
                Console.WriteLine("Mês inválido");
                break;
        }

        Console.WriteLine("\nAperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}