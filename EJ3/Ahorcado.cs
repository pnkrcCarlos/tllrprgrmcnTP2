using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ3
{
    class Ahorcado
    {
        private static readonly String[] PALABRAS = {
            "rojo", "azul", "verde",
            "magenta", "cian", "amarillo",
            "blanco", "negro", "gris",
            "perro", "gato", "hamster",
            "elefante", "leon", "tigre",
            "mono", "murcielago", "jirafa",
            "orquidea", "jazmin", "girasol",
            "manzana", "banana", "durazno",
            "uva", "pera", "sandia",
            "naranja", "limon", "otorrinolaringologo"
        };

        private String iPalabra;
        private bool[] iLetras;
        private int iIntentos;

        public Ahorcado() : this(10) { }
        /// <summary>
        /// Crea una nueva instancia de Ahorcado.
        /// </summary>
        /// <param name="pIntentos">Cantidad de intentos permitidos.</param>
        public Ahorcado(int pIntentos)
        {
            this.iIntentos = pIntentos;

            Random random = new Random();
            this.iPalabra = PALABRAS[random.Next(30)];

            this.iLetras = new bool[this.iPalabra.Length];
        }

        public String Palabra
        {
            get { return this.iPalabra; }
        }

        public int Intentos
        {
            get { return this.iIntentos; }
        }

        public bool[] Letras
        {
            get { return this.iLetras; }
        }

        /// <summary>
        /// Devuelve true si la palabra ha sido descubierta, y false de lo contrario.
        /// </summary>
        public bool PalabraDescubierta()
        {
            int marcadas = 0;
            for (int i = 0; i < this.Letras.Length; i++)
            {
                if (this.Letras[i])
                {
                    marcadas++;
                }
            }
            return (marcadas == this.Palabra.Length);
        }

        /// <summary>
        /// Envia un caracter para verificar su existencia en la palabra actual, y devuelve true si existe. De lo contrario, devuelve false y reduce los intentos.
        /// </summary>
        /// <param name="pLetra">Letra que se va a verificar.</param>
        public bool Intentar(char pLetra)
        {
            bool exito = false;
            for (int i = 0; i < this.iPalabra.Length; i++)
            {
                if (this.Palabra[i] == pLetra)
                {
                    this.Marcar(i);
                    exito = true;
                }
            }
            if (!exito)
            {
                this.ReducirIntentos();
            }
            return exito;
        }

        private void ReducirIntentos()
        {
            this.iIntentos--;
        }

        private void Marcar(int pPosicion)
        {
            this.iLetras[pPosicion] = true;
        }

    }
}
