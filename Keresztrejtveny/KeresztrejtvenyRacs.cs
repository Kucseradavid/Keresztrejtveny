using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keresztrejtveny
{
    internal class KeresztrejtvenyRacs
    {
        private List<string> Adatsorok {  get; set; }
        private char[,] Racs { get; set; }
        private int[,] Sorszamok { get; set; }

        public int OszlopokDb ()
        {
            return this.Adatsorok.Count();
        }
        public int SorokDb ()
        {
            return this.Adatsorok[0].Length;
        }

        private void BeolvasAdatsorok (string forras)
        {
            StreamReader olv = new StreamReader(forras);
            while (!olv.EndOfStream)
            {
                string sor = olv.ReadLine();
                this.Adatsorok.Add(sor);
            }
            olv.Close();
        }
        private void FeltoltRacs ()
        {
            for ()
        }
        public KeresztrejtvenyRacs (string forras)
        {
            BeolvasAdatsorok(forras);
            int o = OszlopokDb();
            int s = SorokDb();
            //még is mi az a majomrágta inicializálás a meghatározott értékekkel ITT????????????
            //ez az egész sz@r úgy túl van bonyolítva hoz azt meg se lehet csinálni
            
        }
    }
}
