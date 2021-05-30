using System;

namespace AB_Matherechner_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathematik x = new Mathematik();
            x.ZeigeAttribute();
            x.EingabeAlles();
            x.BerechneKreisDurchmesser();
            x.BerechneKreisFlaeche();
            x.BerechneRechteckFlaeche();
            x.BerechneRest19();
            x.BerechneKreisUmfang();
            x.BerechneKugelVolumen();

            x.AusgabeDurchmesser();
            x.AusgabeKreisFlaeche();
            x.AusgabeKreisumfang();
            x.AusgabeKugelvolumen();
            x.AusgabeRechteckFlaeche();
            x.AusgabeRest19();
            Console.ReadKey();
        }

    }
}
