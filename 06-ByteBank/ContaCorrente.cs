using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _06_ByteBank {
    public class ContaCorrente {

        // titular é um tipo de referência a classe Cliente
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double _saldo = 100;

        public double Saldo {
            get {
                return _saldo;
            }
            set {
                if (value < 0) {
                    return;
                }

                _saldo = value;
            }
        }

        // this para acessar um atributo
        public bool Sacar(double valor) {

            if (_saldo < valor) {
                return false;
            }
            else {
                _saldo -= valor;
                return true;
            }
        }
        // quando nosso método não retorna nenhum valor -> "void"
        public void Depositar(double valor) {

            _saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino) {
            if (_saldo < valor) {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;



        }
    }
}
