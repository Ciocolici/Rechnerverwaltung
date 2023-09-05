using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rechnerverwaltung
{
    internal class Terminal: Rechner
    {
        public Server ReferenzServer { get; set; }
        public string Standort { get; set; }

        public Terminal(string name, string ipAdresse, Server referenzServer, string standort) : base(name, ipAdresse)
        {
            ReferenzServer = referenzServer;
            Standort = standort;
        }
        public override void Ausgabe()
        {
            Console.WriteLine($"Server:\t{ReferenzServer}");
            Console.WriteLine($"Standort:\t{Standort}");
            base.Ausgabe();
        }
    }
}
