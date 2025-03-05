using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicatie
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog cat = new Catalog();
            cat.Adauga(new Componenta("1003"));
            cat.Adauga(new Liniar("1002", TipLiniar.Rezistor, 100, Unitate.fara, 500, 1200,"Ceramic"));
            CircuitIntegrat cint = new CircuitIntegrat("1432", "Punte redresoare");
            cint.porturi.Add("IN+");
            cint.porturi.Add("IN-");
            cint.porturi.Add("OUT+");
            cint.porturi.Add("OUT-");
            cint.alteSpec.Add("Tensiune Maxima: 400V");
            cat.Adauga(cint);
            cat.Adauga(new Sursa("1922", TipSursa.Putere, Semnal.Continuu, 100, 0, Unitate.fara, Unitate.fara, 0));
            cat.Adauga(new Sursa("1922", TipSursa.Tensiune, Semnal.Rectangular, 400, 3, Unitate.fara, Unitate.kilo, 0));
            Console.WriteLine($"Nr total componente: {cat.Nr}");
            Console.WriteLine(cat.Afisare());
        }
    }
}
