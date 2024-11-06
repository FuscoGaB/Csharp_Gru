using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRU
{
    internal class Stazione
    {
        private string numSer;
        private Gru gru;

        public string NumSer
        {
            get { return numSer; }
        }

        public Gru Gru
        {
            get { return gru; }
            set { gru = value; }
        }

        public Stazione(string numSer)
        {
            this.numSer = numSer;
            Gru = null;
        }

        public void accendiTutto()
        {
            if (gru != null)
            {
                gru.accendi();
            }
        }

        public void gruSu()
        {
            if (gru != null)
            {
                gru.spostaSu();
            }
        }

        public void gruGiu()
        {
            if (gru != null)
            {
                gru.spostaGiu();
            }
        }

    }
}
