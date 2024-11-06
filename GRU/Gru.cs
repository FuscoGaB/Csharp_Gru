using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRU
{
    internal class Gru
    {
        private int numSer;
        private string modello;
        private double altezzaMax;
        private double altezzaMin;
        private double pesoMax;
        private double pesoMin;
        private double altezzaGancio;
        private bool stato;

        public int NumSer
        {
            get { return numSer; }
        }

        public string Modello
        {
            get { return modello; }
        }

        public double PesoMax
        {
            get { return pesoMax; }
        }

        public double PesoMin
        {
            get { return pesoMin; }
        }

        public double AltezzaMax
        {
            get { return altezzaMax; }
        }

        public double AltezzaMin
        {
            get { return altezzaMin; }
        }

        public double AltezzaGancio
        {
            get { return altezzaGancio; }
            set { altezzaGancio = value; }
        }
        public bool Stato
        {
            get { return stato; }
            set { stato = value; }
        }

        public void accendi()
        {
            Stato = true;
        }

        public void spostaSu()
        {
            altezzaGancio = -10;
        }

        public void spostaGiu()
        {
            altezzaGancio = +10;
        }

        public Gru(int numSer, string modello, double altezzaMax, double altezzaMin, double pesoMax, double pesoMin, double altezzaGancio, bool stato)
        {
            this.numSer = numSer;
            this.modello = modello;
            this.altezzaMax = altezzaMax;
            this.altezzaMin = altezzaMin;
            this.pesoMax = pesoMax;
            this.pesoMin = pesoMin;
            this.altezzaGancio = altezzaGancio;
            this.stato = stato;
        }

    }
}
