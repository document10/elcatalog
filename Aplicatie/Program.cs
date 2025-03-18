using System;
using System.Configuration;
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
            CatalogFisier cat = new CatalogFisier(ConfigurationManager.AppSettings["NumeFisier"]);
            /*Decomentati daca nu aveti fisierul initial
            cat.Adauga(new Componenta("1003"));
            cat.Adauga(new Liniar("1002", TipLiniar.Rezistor, 100, Unitate.fara, 500, 1200, "Ceramic"));
            cat.Adauga(new Sursa("1922", TipSursa.Putere, Semnal.Continuu, 100, 0, Unitate.fara, Unitate.fara, 0));
            cat.Adauga(new Sursa("1922", TipSursa.Tensiune, Semnal.Rectangular, 400, 3, Unitate.fara, Unitate.kilo, 0));
            cat.Adauga(new Dioda("1943", TipDioda.Zener, 0.7, 7, 100, "Germaniu"));
            CircuitIntegrat cint = new CircuitIntegrat("1432", "Punte redresoare");
            cint.porturi.Add("IN+");
            cint.porturi.Add("IN-");
            cint.porturi.Add("OUT+");
            cint.porturi.Add("OUT-");
            cint.alteSpec.Add("Tensiune Maxima: 400V");
            cat.Adauga(cint);
            */
            //test eliminare componenta
            Console.WriteLine("Elimina o componenta dupa ID:");
            string ccod = Console.ReadLine();
            bool elim = cat.Elimina(ccod);
            if (elim == true) Console.WriteLine("Componenta Eliminata");
            else Console.WriteLine("Nu a fost gasit");
            //copia in memorie va fi necesara pentru afisare
            Catalog mcat = cat.CopieMemorie();
            Console.WriteLine($"Nr total componente: {cat.Nr}\n{mcat.Inventar()}\nReprezentare Fisier:\n{mcat.InvFis()}\nCauta dupa cod:");
            //test cautare componenta
            ccod = Console.ReadLine();
            Componenta cc = cat.CautaCod(ccod);
            if (cc != null) Console.WriteLine(cc.Info());
            else Console.WriteLine("Nu a fost gasit");
        }
    }
}
