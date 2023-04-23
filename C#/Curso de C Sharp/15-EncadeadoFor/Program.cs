using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 15 - Encadeando o For\n");

        //*
        //**
        //***
        //****
        //Com break
        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
            {
                Console.Write("*");
                if (contadorColuna >= contadorLinha)
                    break;
            }
            Console.WriteLine();
        }

        //ou sem break
        for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
        {
            for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
            {
                Console.Write("*");
               
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nAperte a tecla enter para fechar......");
        Console.ReadLine();
    }
}
