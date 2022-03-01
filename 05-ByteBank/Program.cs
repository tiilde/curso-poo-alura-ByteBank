using System;

namespace _05_ByteBank {
    class Program {
        static void Main(string[] args) {

            //Cliente cliente1 = new Cliente();
            //cliente1.nome = "Maria";
            //cliente1.profissao = "Desenvolvedora C#";
            //cliente1.cpf = "123.000.000-00";

            //ContaCorrente conta = new ContaCorrente();

            //conta.titular = cliente1;
            //conta.saldo = 1.000;
            //conta.agencia = 123;
            //conta.numero = 4445566;

            //Console.WriteLine("Cliente: " + cliente1.nome);

            ContaCorrente conta = new ContaCorrente();
            conta.titular = new Cliente();

            conta.titular.nome = "Nicole";
            conta.titular.profissao = "Desenvolvedora C#";
            conta.titular.cpf = "456.000.000-00";

            Console.WriteLine("Titular da conta: " + conta.titular.nome);
            Console.WriteLine("CPF: " + conta.titular.cpf);
            Console.WriteLine("Profissão: " + conta.titular.profissao);

            Console.ReadLine();



        }
    }
}
