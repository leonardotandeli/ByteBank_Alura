

using ByteBank;



ContaCorrente contaDoLeonardo = new ContaCorrente(323, "21312321");

Console.WriteLine("O Número da conta de Leonardo é: " + contaDoLeonardo.Conta);
Console.WriteLine("Total de Contas: " + ContaCorrente.TotalDeContasCriadas);


ContaCorrente contaDoLeonardo2 = new ContaCorrente(3233, "23232");

Console.WriteLine("O Número da conta 2 de Leonardo é: " + contaDoLeonardo.Conta);
Console.WriteLine("Total de Contas: " + ContaCorrente.TotalDeContasCriadas);
