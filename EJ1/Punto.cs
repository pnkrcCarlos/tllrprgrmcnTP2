﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ1
{
    class Punto
    {
        private double iX;
        private double iY;

        public Punto() : this(0.0, 0.0) { }

        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        public double X
        {
            get { return this.iX; }
            //set { this.iX = value; }
        }

        public double Y
        {
            get { return this.iY; }
            //set { this.iY = value; }
        }

        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow(this.X - pPunto.X, 2) + Math.Pow(this.Y - pPunto.Y, 2));
        }

    }
}
