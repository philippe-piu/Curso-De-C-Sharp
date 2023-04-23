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