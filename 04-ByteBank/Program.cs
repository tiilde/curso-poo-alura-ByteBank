using System;

namespace _04_ByteBank {
    internal class Program {
        static void Main(string[] args) {
            
            ContaCorrente conta1 = new ContaCorrente();

            conta1.titular = "Maria";

            Console.WriteLine("Saldo: " + conta1.saldo );

            conta1.Sacar(50);

            Console.WriteLine("Saldo: " + conta1.saldo);

            Console.ReadLine();
        }
    }
}
