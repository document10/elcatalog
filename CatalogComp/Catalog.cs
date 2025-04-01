using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Catalog
{
    public List<Componenta> comps { get; set; }
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

    public bool Elimina(string ccod)
    {
        Componenta cc = comps.Find(c => c.cod == ccod);
        if (cc == null) return false;
        else
        {
            comps.Remove(cc);
            return true;
        }
    }
    //pentru afisare pe ecran
    public string Inventar()
    {
        string val = "";
        foreach (Componenta comp in comps)
        {
            val += comp.ToString()+"\n";
        }
        return val;
    }
    //pentru scriere in fisier
    public string InvFis()
    {
        string val = "";
        foreach (Componenta comp in comps)
        {
            val += comp.InfoFis() + "\n";
        }
        return val;
    }

    public Componenta CautaCod(string ccod)
    {
        return comps.Find(c => c.cod == ccod);
    }

}

