using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal class Rechner
    {
        public string Name { get; set; }
        public string IpAdresse { get; set; }

        public Rechner(string name, string ipAdresse)
        {
            Name = name;
            IpAdresse = ipAdresse;
        }

        public virtual void Ausgabe()
        {
            Console.WriteLine($"Name:\t\t{Name}");
            Console.WriteLine($"IpAdresse:\t{IpAdresse}");
        }
    }
}
