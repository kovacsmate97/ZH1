using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZH1
{
    public class Verseny
    {
        private int Atlagsebesseg;
        private int MegtettTav;
        private int Korok = 100;
        private int Labankenti_sebesseg;
        public List<Verseny> VersenyzoID = new List<Verseny>();

        

        public void Tajekoztat()
        {
            Korok++;
        }

        public void Rajt()
        {
            throw new System.NotImplementedException();
        }

        public void Vége()
        {
            throw new System.NotImplementedException();
        }
    }
}