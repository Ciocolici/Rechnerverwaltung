using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System;

namespace Rechnerverwaltung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erstelle Sie die Klassen für ein Programm der Rechnerverwaltung.Es sollen
            // alle Rechner eines Unternehmens in einem Programm verwaltet werden. Dabei
            // muss folgendes berücksichtigt werden:
            // a.Für jeden Rechner:
            // - Name
            // - IP - Adresse

            // b.Für Büro-Workstations:
            // -Prozessorleistung
            // - Größe des Arbeitsspeichers
            // -Größe der Festplatte

            // c.Für Grafische Arbeitsplätze:
            // - Prozessorleistung
            // - Größe des Arbeitsspeichers
            // - Größe der Festplatte
            // - Größe des Monitors
            // - Modellname der Grafikkarte

            // d.Für Server:
            // - Anzahl der Prozessoren und deren Leistung
            // - Größe des Arbeitsspeichers
            // - Anzahl der Festplatten und deren Größe
            // - Funktion des Servers
            // - Leistung der Netzwerkanbindung

            // e.Für Terminals:
            // - Referenz auf den Server zu dem sie verbunden sind
            // - Standort


            // 1.) Erstellen Sie nach den obigen Angaben eine Klassenhierarchie. - erstellt als "18Rechnerverwaltung Klassenhierarchie.png" in die "CSharpShortProjects" Ordner
            // 2.) Legen Sie die Klassen in Visual Studio an.
            // 3.) Erstellen / Überschreiben Sie eine Methode, welche für eine
            //    Ausgabe in der Konsole mit allen Daten sorgt.
            //    Vererben Sie diese weiter und verändern Sie diese, um sie
            //    an die jeweilige Klassen anzupassen.
            // 4.) Schreiben Sie für jede Klasse einen Konstruktor, der alle
            //    Felder befüllt.
            //5.) Erstellen Sie eine Klasse "ITVerwaltung", welche, in geeigneter
            //    Form, alle Rechner eines Unternehmens enthält.
            //    (Hinweis: List<T>)
            //6.) Erstellen Sie in dieser Klasse einen Zähler, welcher die Anzahl
            //    der Rechner angibt.Auf diesen soll kein Zugriff von ausserhalb
            //    möglich sein.
            //7.) In der Klasse "ITVerwaltung" wird nun eine Methode benötigt,
            //    welche alle in dieser Klasse aufgenommenen Rechner, mit allen
            //    Daten ausgibt.
            //8.) Erstellen Sie in der Klasse "ITVerwaltung" eine Möglichkeit,
            //    neue Rechner hinzuzufügen oder zu entfernen.
        }
    }
}