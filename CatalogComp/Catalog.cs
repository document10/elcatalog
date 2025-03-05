using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Catalog
{
    public List<Componenta> comps;
    public int Nr
    {
        get
        {
            return comps.Count;
        }
        set
        {

        }
    }

    public Catalog()
    {
        this.comps = new List<Componenta>();
    }

    public void Adauga(Componenta c)
    {
        comps.Add(c);
    }

    public string Afisare()
    {
        string val = "";
        foreach (Componenta comp in comps)
        {
            val += comp.Afisare()+"\n";
        }
        return val;
    }
}

