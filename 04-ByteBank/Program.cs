using System;

namespace _04_ByteBank {
    class Program {
        static void Main(string[] args) {
            
            ContaCorrente conta1 = new ContaCorrente();
            ContaCorrente conta2 = new ContaCorrente();

            conta1.titular = "Maria";
            conta2.titular = "Nicole";

            conta1.saldo = 500;
            conta2.saldo = 500;

            Console.WriteLine("Titular: " + conta1.titular + "\n" + "Saldo: " + conta1.saldo );
            Console.WriteLine("Titular: " + conta2.titular + "\n" + "Saldo: " + conta2.saldo);


            // sacar
            bool resultadoSaque = conta1.Sacar(50);

            Console.WriteLine("Saldo: " + conta1.saldo);
            Console.WriteLine(resultadoSaque);

            // depositar
            conta1.Depositar(500);
            Console.WriteLine("Saldo: " + conta1.saldo);

            // transferir
            bool resultadoTransferencia = (conta1.Transferir(100, conta2));
            Console.WriteLine("Saldo de " + conta1.titular + ": " + conta1.saldo);
            Console.WriteLine("Saldo de " + conta2.titular + ": " + conta2.saldo);
            Console.WriteLine("Resultado transferência: " + resultadoTransferencia);




            Console.ReadLine();
        }
    }
}
