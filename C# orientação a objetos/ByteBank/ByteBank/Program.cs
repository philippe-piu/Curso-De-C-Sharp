using ByteBank;

//Objeto
ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "Andre Silva";
contaDoAndre.numeroAgencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo = 100;

Console.WriteLine("Saldo da Conta do Andre = "+contaDoAndre.saldo);