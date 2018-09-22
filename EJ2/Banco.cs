using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Banco
    {
        private static Cuentas sesion;
        private static Cliente cliente;

        public void IniciarSesion(TipoDocumento pTipoDocumento, String pNroDocumento)
        {
            cliente = new Cliente(pTipoDocumento, pNroDocumento, "Fulano");
            sesion = new Cuentas(cliente);
        }
        
        public bool Acreditar(double pMonto, int pCuenta)
        {
            switch (pCuenta)
            {
                case 1:
                    sesion.Corriente.AcreditarSaldo(pMonto);
                    return true;
                case 2:
                    sesion.Ahorros.AcreditarSaldo(pMonto); 
                    return true;
                default:
                    return false;
            }
        }

        public bool Debitar(double pMonto, int pCuenta)
        {
            switch (pCuenta)
            {
                case 1:
                    return sesion.Corriente.DebitarSaldo(pMonto);
                case 2:
                    return sesion.Ahorros.DebitarSaldo(pMonto);
                default:
                    return false;
            }
        }


        public double Consultar(int pCuenta)
        {
            switch (pCuenta)
            {
                case 1:
                    return sesion.Corriente.Saldo;
                case 2:
                    return sesion.Ahorros.Saldo;
                default:
                    throw new System.ArgumentOutOfRangeException("pCuenta", "Solo puede ser 1 para Cuenta corriente, o 2 para Caja de ahorros.");
            }
        }
    }
}
