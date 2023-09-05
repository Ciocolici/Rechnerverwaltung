using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal class BueroWorkstations: Rechner
    {
        public double ProzessorenLeistung { get; set; }
        public int ArbeitsspeicherGroesse { get; set; }
        public int FestplattenGroesse { get; set; }

        public BueroWorkstations(string name, string ipAdresse, double prozessorenLeistung, int arbeitsspeicherGroesse, int festplattenGroesse) : base(name,ipAdresse)
        {
            ProzessorenLeistung = prozessorenLeistung;
            ArbeitsspeicherGroesse = arbeitsspeicherGroesse;
            FestplattenGroesse = festplattenGroesse;
        }

        public override void Ausgabe()
        {
            Console.WriteLine($"Leistung Prozessoren:\t{ProzessorenLeistung}");
            Console.WriteLine($"Größe Arbeitsspeicher:\t{ArbeitsspeicherGroesse}");
            Console.WriteLine($"Größe Festplatten:\t{FestplattenGroesse}");
            base.Ausgabe();
        }
    }
}
