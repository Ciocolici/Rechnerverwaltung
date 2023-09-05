using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal class ITVerwaltung
    {
        private static List<Rechner> rechnerListe = new List<Rechner>();

        private static int Zaehler()
        { 
            return rechnerListe.Count;
        }
        public static void DatenAusgabe()
        {
            foreach (var item in rechnerListe)
            {
                if (item is Server)
                    item.ToString();
                else if (item is Terminal)
                    item.ToString();
                else if (item is BueroWorkstations)
                    item.ToString();
                else if (item is GrafischeArbeitsplaetze)
                    item.ToString();
            }
        }

        public static void RechnerHinzufuegen(Rechner name)
        {
            rechnerListe.Add(name);
        }

        public static void RechnerEntfernen(Rechner name)
        {
            rechnerListe.Remove(name);
        }
    }
}
