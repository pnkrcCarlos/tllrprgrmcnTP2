using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class CalculadoraGeometrica // Controlador
    {
        public double PerimetroCirculo(double pCx, double pCy, double pRadio)
        {
            Punto centro = new Punto(pCx, pCy);
            Circulo circulo = new Circulo(centro, pRadio);
            return circulo.Perimetro;
        }

        public double AreaCirculo(double pCx, double pCy, double pRadio)
        {
            Punto centro = new Punto(pCx, pCy);
            Circulo circulo = new Circulo(centro, pRadio);
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

        public double AreaTriangulo(double pAx, double pAy, double pBx, double pBy, double pCx, double pCy)
        {
            Punto puntoA = new Punto(pAx, pAy);
            Punto puntoB = new Punto(pBx, pBy);
            Punto puntoC = new Punto(pCx, pCy);
            Triangulo triangulo = new Triangulo(puntoA, puntoB, puntoC);
            return triangulo.Area;
        }

    }
}
