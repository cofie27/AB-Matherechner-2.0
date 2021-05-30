using System;
using System.Collections.Generic;
using System.Text;

namespace AB_Matherechner_2._0
{
    class Mathematik
    {
        //Attribute deklarieren
        private ulong radius;                            //wenn Wert mit Nachkommastellen, dann double
        private double seiteA;
        private double seiteB;
        private ulong riesenzahl;
        private float flaecheKreis;
        private float flaecheRechteck;
        private float umfangKreis;
        private float volumenKugel;
        private float durchmesser;
        private short rest19;
        //private float ergebnisFlaecheKreis;
        //private float ergebnisFlaecheRechteck;
        //private float ergebnisUmfangKreis;
        //private float ergebnisVolumenKugel;
        //private float ergebnisDurchmesser;
        //private float ergebnisRest19;
        //Definition des Konstruktors
        // eine Methode, die automatisch ausgeführt wird, wenn ich ein Objekt der Klasse erz.
        public Mathematik()
        {
            //Initialisieren der Attribute
            radius = 1;
            seiteA = 1;
            seiteB = 1;
            riesenzahl = 1;
        }

        public void ZeigeAttribute()
        {
            Console.WriteLine("Radius: " + Convert.ToString(radius) + "\nSeiteA: " + Convert.ToString(seiteA) + "\nSeiteB: " + Convert.ToString(seiteB) + "\nRiesenzahl: " + Convert.ToString(riesenzahl) + "\n");
        }
        public void EingabeRadius()
        {
            Console.WriteLine("Bitte den Radius eingeben: ");
            radius = Convert.ToByte(Console.ReadLine());
            
        }
        public void EingabeSeiteA()
        {
            Console.WriteLine("Bitte Seite A eingeben: ");
            seiteA = Convert.ToByte(Console.ReadLine());
        }
        public void EingabeSeiteB()
        {
            Console.WriteLine("Bitte den Seite B eingeben: ");
            radius = Convert.ToByte(Console.ReadLine());
        }
        public void EingabeRiesenzahl()
        {
            Console.WriteLine("Bitte die Riesennzahl eingeben: ");
            radius = Convert.ToByte(Console.ReadLine());
        }
        public void EingabeAlles()
        {
            Console.WriteLine("Bitte den Radius eingeben: ");
            radius = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Bitte Seite A eingeben: ");
            seiteA = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Bitte den Seite B eingeben: ");
            seiteB = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Bitte die Riesennzahl eingeben: ");
            riesenzahl = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("\n");
        }
        public void BerechneKreisFlaeche()
        {
            flaecheKreis = Convert.ToSingle(Math.PI * (radius * radius));
            //ergebnisFlaecheKreis = flaecheKreis;
        }
        public void BerechneRechteckFlaeche()
        {
            flaecheRechteck = Convert.ToSingle(seiteA * seiteB);
            //ergebnisFlaecheRechteck = flaecheRechteck;
        }
        public void BerechneKugelVolumen()
        {
            volumenKugel = Convert.ToSingle((4.0 / 3) * Math.PI * (radius * radius * radius));
            //ergebnisVolumenKugel = volumenKugel; 
        }
        public void BerechneKreisUmfang()
        {
            umfangKreis = Convert.ToSingle((Math.PI * 2 * radius));
            //ergebnisUmfangKreis = umfangKreis;
        }
        public void BerechneKreisDurchmesser()
        {
            durchmesser = 2 * radius;
            //ergebnisDurchmesser = durchmesser;
        }
        public void BerechneRest19()
        {
            rest19 = Convert.ToInt16(riesenzahl % 19);
            //ergebnisRest19 = rest19;
        }
       /*public void BerechneAlles()
        {
            flaecheKreis = Convert.ToSingle(Math.PI * (radius * radius));
            flaecheRechteck = Convert.ToSingle(seiteA * seiteB);
            volumenKugel = Convert.ToSingle((4.0 / 3) * Math.PI * (radius * radius * radius));
            umfangKreis = Convert.ToSingle((Math.PI * 2 * radius));
            durchmesser = 2 * radius;
        }*/
       public void AusgabeKreisFlaeche()
        {
            Console.WriteLine("Kreisflaeche: " + flaecheKreis);
        }
        public void AusgabeRechteckFlaeche()
        {
            Console.WriteLine("Rechteckflaeche: " + flaecheRechteck);
        }
        public void AusgabeKreisumfang()
        {
            Console.WriteLine("Kreisumfang: " + umfangKreis);
        }
        public void AusgabeKugelvolumen()
        {
            Console.WriteLine("Kugelvolumen: " + volumenKugel);
        }
        public void AusgabeDurchmesser()
        {
            Console.WriteLine("Durchmesser: " + durchmesser);
        }
        public void AusgabeRest19()
        {
            Console.WriteLine("Rest19: " + rest19);
        }
    }
}