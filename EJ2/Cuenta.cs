using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cuenta
    {
        private double iSaldo;
        private double iAcuerdo;

        public Cuenta(double pAcuerdo) : this(0.0, pAcuerdo) { }

        public Cuenta(double pSaldo, double pAcuerdo)
        {
            this.iSaldo = pSaldo;
            this.iAcuerdo = pAcuerdo;
        }

        public double Saldo
        {
            get { return this.iSaldo; }
        }

        public double Acuerdo
        {
            get { return this.iAcuerdo; }
        }

        public void AcreditarSaldo(double pSaldo)
        {
            this.iSaldo += pSaldo;
        }

        public bool DebitarSaldo(double pSaldo)
        {
            if (this.Saldo + this.Acuerdo < pSaldo)
            {
                return false;
            }
            else
            {
                this.iSaldo -= pSaldo;
                return true;
            }
        }
    }
}
