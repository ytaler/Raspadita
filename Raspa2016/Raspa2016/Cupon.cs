using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Raspa2016
{
    public class Cupon
    {
        private double alto;
        private double ancho;
        private string premioValor;
        private double premioX;
        private double premioY;
        private string codigoValor;
        private double codigoX;
        private double codigoY;
        private string semanaValor;
        private double semanaX;
        private double semanaY;

        public Cupon(double alto, double ancho, string premioValor, double premioX, double premioY, string codigoValor, double codigoX, double codigoY, string semanaValor, double semanaX, double semanaY)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.premioValor = premioValor;
            this.premioX = premioX;
            this.premioY = premioY;
            this.codigoValor = codigoValor;
            this.codigoX = codigoX;
            this.codigoY = codigoY;
            this.semanaValor = semanaValor;
            this.semanaX = semanaX;
            this.semanaY = semanaY;
        }

        public Cupon()
        {
            
        }

        public double pAlto
        {
            get { return alto; }
            set { alto = value; }
        }

        public double pAncho
        {
            get { return ancho; }
            set { ancho = value; }
        }

        public string pPremioValor
        {
            get { return premioValor; }
            set { premioValor = value; }
        }

        public double pPremioX
        {
            get { return premioX; }
            set { premioX = value; }
        }

        public double pPremioY
        {
            get { return premioY; }
            set { premioY = value; }
        }

        public string pCodigoValor
        {
            get { return codigoValor; }
            set { codigoValor = value; }
        }

        public double pCodigoX
        {
            get { return codigoX; }
            set { codigoX = value; }
        }

        public double pCodigoY
        {
            get { return codigoY; }
            set { codigoY = value; }
        }

        public string pSemanaValor
        {
            get { return semanaValor; }
            set { semanaValor = value; }
        }

        public double pSemanaX
        {
            get { return semanaX; }
            set { semanaX = value; }
        }

        public double pSemanaY
        {
            get { return semanaY; }
            set { semanaY = value; }
        }
    }
}
