using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPIU
{
    class Program
    {
        static void Main(string[] args)
        {
            Componenta c1=new Componenta(),c2 = new Componenta("1003","KOHMI",tip.Rezistor,100f);
            Console.WriteLine(c1.Afisare());
            Console.WriteLine(c2.Afisare());
            CircuitIntegrat ci1 = new CircuitIntegrat(), ci2 = new CircuitIntegrat("1111", "Punte redresoare");
            ci2.porturi.Add("IN+");
            ci2.porturi.Add("IN-");
            ci2.porturi.Add("OUT+");
            ci2.porturi.Add("OUT-");
            ci2.alteSpec.Add("Tensiune maxima 300V");
            Console.WriteLine(ci1.Afisare());
            Console.WriteLine(ci2.Afisare());
        }
    }
}
