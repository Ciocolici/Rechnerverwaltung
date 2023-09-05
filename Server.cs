using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnerverwaltung
{
    internal class Server: Rechner
    {
        public int ProzessorenAnzahl { get; set; }
        public double ProzessorenLeistung { get; set; }
        public int ArbeitsspeicherGroesse { get; set; }
        public int FestplattenAnzahl { get; set; }
        public string ServerFunktion { get; set; }
        public double NetzwerkanbindungLeistung { get; set; }

        public Server(string name, string ipAdresse, int prozessorenAnzahl, double prozessorenLeistung, int arbeitsspeicherGroesse, int festplattenAnzahl, string serverFunktion, double netzwerkanbindungLeistung) : base(name, ipAdresse)
        {
            ProzessorenAnzahl = prozessorenAnzahl;
            ProzessorenLeistung = prozessorenLeistung;
            ArbeitsspeicherGroesse = arbeitsspeicherGroesse;
            FestplattenAnzahl = festplattenAnzahl;
            ServerFunktion = serverFunktion;
            NetzwerkanbindungLeistung = netzwerkanbindungLeistung;
        }
        public override void Ausgabe()
        { 
            Console.WriteLine($"Anzahl Prozessoren:\t{ProzessorenAnzahl}");
            Console.WriteLine($"Leistung Prozessoren:\t{ProzessorenLeistung}");
            Console.WriteLine($"Größe Arbeitsspeicher:\t{ArbeitsspeicherGroesse}");
            Console.WriteLine($"Anzahl Festplatten:\t{FestplattenAnzahl}");
            Console.WriteLine($"Server Funktion:\t{ServerFunktion}");
            Console.WriteLine($"Leistung Netzwerkanbindung:\t{NetzwerkanbindungLeistung}");
            base.Ausgabe();
        }
    }
}
