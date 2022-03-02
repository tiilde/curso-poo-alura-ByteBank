using System;

namespace _07_ByteBank {
    internal class Program {
        static void Main(string[] args) {
            
            ContaCorrente conta = new ContaCorrente(123, 111222334);
            ContaCorrente conta2 = new ContaCorrente(456, 555666778);

            Console.WriteLine(conta.Numero);
            Console.WriteLine(conta.Agencia);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();

        }
    }
}
