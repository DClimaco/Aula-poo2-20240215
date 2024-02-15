using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240215
{
    public class ContaCorrente
    {
        private double saldo;
        Proprietario proprietario;

        public ContaCorrente(double saldo, Proprietario proprietario)
        {
            this.saldo = saldo;
            this.proprietario = proprietario;
        }

        public void depositar(double saldo)
        {
            
        }

        public void sacar(double saldo)
        {

        }

        public double Saldo
        {
            get => saldo;
            set => saldo = value;
        }
    }
}
