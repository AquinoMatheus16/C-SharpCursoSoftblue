﻿using System;

namespace Documentacao
{
    class Program
    {
        static void Main()
        {
            ContaCorrente c = new ContaCorrente(100);
            double saldo = c.Saldo;
            c.Depositar(2000);
            double bloqueio = c.Bloquear();
        }
    }
}