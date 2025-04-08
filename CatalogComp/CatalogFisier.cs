using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class CatalogFisier
{

    public string numeFisier { get; set; }

    public CatalogFisier(string numeFisier)
    {
        this.numeFisier = numeFisier;
        Stream fisier = File.Open(numeFisier, FileMode.OpenOrCreate);
        fisier.Close();
    }

    public int Nr
    {
        get
        {
            int nr = 0;
            using (StreamReader fisier = new StreamReader(numeFisier))while(fisier.ReadLine() != null) nr++;
            return nr;
        }
        set
        {

        }
    }

    public Catalog CopieMemorie()
    {
        Catalog cat = new Catalog();
        using(StreamReader fisier = new StreamReader(numeFisier))
        {
            string linie;

            while ((linie = fisier.ReadLine()) != null)
            {
                switch (linie.Split('|')[0])
                {
                    case "Comp":
                        cat.Adauga(new Componenta(linie.Split('|')[1]));
                        break;
                    case "Liniar":
                        cat.Adauga(new Liniar(linie));
                        break;
                    case "Dioda":
                        cat.Adauga(new Dioda(linie));
                        break;
                    case "Sursa":
                        cat.Adauga(new Sursa(linie));
                        break;
                    case "CI":
                        cat.Adauga(new CircuitIntegrat(linie));
                        break;
                    default:
                        cat.Adauga(new Componenta($"COMPONENTA INVALIDA:{linie}"));
                        break;
                }
            }
        }
        return cat;
    }

    public void Adauga(Componenta c)
    {
        using (StreamWriter fisier = new StreamWriter(numeFisier, true)) fisier.WriteLine(c.InfoFis());
    }

    public bool Elimina(string ccod)
    {
        Catalog cat = CopieMemorie();
        bool ex = cat.Elimina(ccod);
        if (ex == true)using (StreamWriter fisier = new StreamWriter(numeFisier, false))fisier.Write(cat.InvFis());
        return ex;
    }

    public List<Componenta> CautaCod(string ccod)
    {
        return CopieMemorie().CautaCod(ccod);
    }
}

