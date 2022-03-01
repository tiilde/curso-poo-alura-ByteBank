﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_ByteBank;


namespace _05_ByteBank {
    public class ContaCorrente {

        public Cliente titular;
        public int agencia;
        public int numero;
        public double saldo = 100;

        // this para acessar um atributo
        public bool Sacar(double valor) {

            if (this.saldo < valor) {
                return false;
            }
            else {
                this.saldo -= valor;
                return true;
            }
        }
        // quando nosso método não retorna nenhum valor -> "void"
        public void Depositar(double valor) {

            this.saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino) {
            if (this.saldo < valor) {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;



        }
    }
}
