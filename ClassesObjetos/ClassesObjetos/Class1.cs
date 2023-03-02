﻿using System;

namespace ClassesObjetos
{
    internal class ContaBancaria
    {
        public string titular;
        public int numConta;
        public double saldo;

        public void Sacar(double valor)
        {
            saldo -= valor;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Tranferir(double valor, ContaBancaria contaDestino)
        {
            Sacar(valor);
            contaDestino.Depositar(valor);
        }
    }
}
