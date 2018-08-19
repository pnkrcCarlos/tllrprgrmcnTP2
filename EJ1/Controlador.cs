using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Controlador
    {
        private List<Punto> iPuntos;
        private List<Triangulo> iTriangulos;
        private List<Circulo> iCirculos;

        public Controlador() : this(new List<Punto>(),new List<Triangulo>(),new List<Circulo>()) { }

        public Controlador(List<Punto> pPuntos, List<Triangulo> pTriangulos, List<Circulo> pCirculos)
        {
            this.iPuntos = pPuntos;
            this.iTriangulos = pTriangulos;
            this.iCirculos = pCirculos;
        }

        public List<Punto> Puntos
        {
            get { return this.iPuntos; }
            set { this.iPuntos = value; }
        }

        public List<Triangulo> Triangulos
        {
            get { return this.iTriangulos; }
            set { this.iTriangulos = value; }
        }

        public List<Circulo> Circulos
        {
            get { return this.iCirculos; }
            set { this.iCirculos = value; }
        }
    }
}
