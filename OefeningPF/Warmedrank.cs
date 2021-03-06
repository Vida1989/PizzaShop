using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningPF
{
    public class Warmedrank : Drank
    {
        public decimal prijsValue = 2.5m;

        private string naamvalue;
        public override decimal Prijs
        {
            get => prijsValue;
        }
        public override List<string> DrankNamen { get; set; } = new List<string>() { "Thee", "Koffie" };
        public override string Naam
        {
            get => naamvalue;

            set
            {
                if (!DrankNamen.Contains(value))
                    throw new Exception("een verkeerde dranknaam wordt opgegeven.");
                naamvalue = value;
            }
        }
        public Warmedrank(string naam) : base(naam) { }
        public override decimal BerekenBedrag() => Prijs;
        public override string ToString() => $"Drank: {Naam} ({Prijs} euro)";
    }
}







//public override DrankNaam Naam
//{
//    get => naamvalue;
//    set
//    {
//        if (value != DrankNaam.Thee && value != DrankNaam.Koffie)
//            throw new Exception("een verkeerde dranknaam wordt opgegeven.");
//        naamvalue = value;
//    }
//}