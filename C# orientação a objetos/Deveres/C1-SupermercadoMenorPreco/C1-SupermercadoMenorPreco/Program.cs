using System;
using C1_SupermercadoMenorPreco;

public class Program
{
    public static void Main(string[] args)
    {
        //Objeto
        Produto produto = new Produto();
        produto.nomeProduto = "Sabonete";
        produto.fabricante = "Dove";
        produto.codigoDeBarras = "1020C555D";
        produto.valorUnitario = 2.30;
        produto.valorCompra = 23.0;
        produto.quantidade = 10;

        Console.WriteLine("Produto " + produto.nomeProduto);
        Console.WriteLine("Fabricante " + produto.fabricante);
        Console.WriteLine("Código de Barras " + produto.codigoDeBarras);
        Console.WriteLine("Valor Unitário R$" + produto.valorUnitario);
        Console.WriteLine("Valor da Compra R$" + produto.valorCompra);
        Console.WriteLine("Quantidade nbo Estoque " + produto.quantidade);

    }
}

/*
 * Contrataram você para desenvolver um sistema de gerenciamento de produtos destinado ao estoque do 
 * Supermercado Menor Preço. O cliente informou a necessidade de cadastrar informações sobre o nome, 
 * fabricante, código de barras, valor unitário, valor de compra e quantidade em estoque de determinado produto.

Este é um exercício opcional e te desafiamos a criar uma classe com base na descrição acima. 
Lembre-se de extrair o máximo de informações que achar necessárias para compor sua classe.
 */