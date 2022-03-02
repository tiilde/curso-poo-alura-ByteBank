using System;

namespace _06_ByteBank {
    internal class Program {
        static void Main(string[] args) {

            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Maria";
            cliente.CPF = "123.000.000-00";
            cliente.Profissao = "Desenvolvedora C#";

            conta.Saldo = -10;
            conta.Titular = cliente;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
