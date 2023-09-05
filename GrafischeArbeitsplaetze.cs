using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rechnerverwaltung
{
    internal class GrafischeArbeitsplaetze: BueroWorkstations
    {
        public double MonitorGroesse { get; set; }
        public string GrafikkarteModellname { get; set; }

        public GrafischeArbeitsplaetze(string name, string ipAdresse, double prozessorenLeistung, int arbeitsspeicherGroesse, int festplattenGroesse, double monitorGroesse, string grafikkarteModellname) : base(name, ipAdresse, prozessorenLeistung, arbeitsspeicherGroesse, festplattenGroesse)
        {
            MonitorGroesse = monitorGroesse;
            GrafikkarteModellname = grafikkarteModellname;
        }

        public override void Ausgabe()
        {
            base.Ausgabe();
            Console.WriteLine($"Größe Monitor:\t{MonitorGroesse}");
            Console.WriteLine($"Modellname Grafikkarte:\t{GrafikkarteModellname}");
        }
    }
}
