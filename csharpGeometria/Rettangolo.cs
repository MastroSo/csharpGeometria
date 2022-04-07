using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpGeometria
{
    internal class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        //----- Costruttore-----
        public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;
        }

        // Metodo Calcolo

        public int calcoloArea()
        {
            int risultato = baseRettangolo * altezzaRettangolo;
            return risultato;
        }



        public int calcoloPerimetro()
        {
            int risultato = (baseRettangolo + altezzaRettangolo) * 2;
            return risultato;


        }
















    }
}
