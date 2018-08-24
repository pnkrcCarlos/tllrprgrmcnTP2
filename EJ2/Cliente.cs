using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cliente
    {
        private TipoDocumento iTipoDocumento;
        private String iNroDocumento;
        private String iNombre;

        public Cliente(TipoDocumento pTipoDocumento, String pNroDocumento, String pNombre)
        {
            this.iTipoDocumento = pTipoDocumento;
            this.iNroDocumento = pNroDocumento;
            this.iNombre = pNombre;
        }

        public TipoDocumento TipoDoc
        {
            get { return this.iTipoDocumento; }
        }

        public String NroDocumento
        {
            get { return this.iNroDocumento; }
        }

        public String Nombre
        {
            get { return this.iNombre; }
        }
    }
}
