using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Controlador
    {
        public double PerimetroCirculo(double pCx, double pCy, double pRadio)
        {
            Punto centro = new Punto(pCx, pCy);
            Circulo circulo = new Circulo(centro, pRadio);
            return circulo.Perimetro;
        }

        public double PerimetroCirculo(Punto pCentro, double pRadio)
        {
            Circulo circulo = new Circulo(pCentro, pRadio);
            return circulo.Perimetro;
        }

        public double AreaCirculo(double pCx, double pCy, double pRadio)
        {
            Punto centro = new Punto(pCx, pCy);
            Circulo circulo = new Circulo(centro, pRadio);
            return circulo.Area;
        }

        public double AreaCirculo(Punto pCentro, double pRadio)
        {
            Circulo circulo = new Circulo(pCentro, pRadio);
            return circulo.Area;
        }

        public double PerimetroTriangulo(double pAx, double pAy, double pBx, double pBy, double pCx, double pCy)
        {
            Punto puntoA = new Punto(pAx, pAy);
            Punto puntoB = new Punto(pBx, pBy);
            Punto puntoC = new Punto(pCx, pCy);
            Triangulo triangulo = new Triangulo(puntoA, puntoB, puntoC);
            return triangulo.Perimetro;
        }

        public double PerimetroTriangulo(Punto pA, Punto pB, Punto pC)
        {
            Triangulo triangulo = new Triangulo(pA, pB, pC);
            return triangulo.Perimetro;
        }

        public double AreaTriangulo(double pAx, double pAy, double pBx, double pBy, double pCx, double pCy)
        {
            Punto puntoA = new Punto(pAx, pAy);
            Punto puntoB = new Punto(pBx, pBy);
            Punto puntoC = new Punto(pCx, pCy);
            Triangulo triangulo = new Triangulo(puntoA, puntoB, puntoC);
            return triangulo.Area;
        }

        public double AreaTriangulo(Punto pA, Punto pB, Punto pC)
        {
            Triangulo triangulo = new Triangulo(pA, pB, pC);
            return triangulo.Area;
        }

        /*
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
        */
    }
}
