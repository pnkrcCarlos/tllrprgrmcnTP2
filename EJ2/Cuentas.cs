using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cuentas
    {
        private Cliente iCliente;
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;

        public Cuentas(Cliente pCliente)
        {
            this.iCliente = pCliente;
            CargarCuentas(pCliente.TipoDoc, pCliente.Nombre);
        }

        private void CargarCuentas(TipoDocumento pTipoDocumento, String pNroDocumento) {
            // Obtener de algun lado los montos en las cuentas usando pTipoDocumento y pNroDocumento
            Random random = new Random();
            double saldoCorriente = random.NextDouble() * 100000;
            double saldoAhorros = random.NextDouble() * 100000;
            double acuerdoC = 1000;
            double acuerdoA = 1000;

            this.iCuentaCorriente = new Cuenta(saldoCorriente, acuerdoC);
            this.iCajaAhorro = new Cuenta(saldoAhorros, acuerdoA);
        }

        public Cuenta Corriente
        {
            get { return this.iCuentaCorriente; }
        }

        public Cuenta Ahorros
        {
            get { return this.iCajaAhorro; }
        }
    }
}
