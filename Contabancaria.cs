using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Abstracao
{
    internal class ContaBancaria
    {
        public string Titular;
        public string NumeroConta;
        public double Saldo;

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo não é suficiente.");
            }
        }

        public void ExibirInformacoesContaBancaria1()
        {
            Console.WriteLine($"Saldo inicial: R${Saldo}");
        }
        public void ExibirInformacoesContaBancaria2()
        {
            Console.WriteLine($"Saldo após depósito: R${Saldo}");
        }
        public void ExibirInformacoesContaBancaria3()
        {
            Console.WriteLine($"Saldo final: R${Saldo}");
            Console.WriteLine("----------------------------------");
        }
    }
}
