using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Componenta
{
    public string cod { get; set; }

    public Componenta(string _c="FARACOD")
    {
        cod = _c;
    }

    public override string ToString()
    {
        return $"Componenta generica ({cod})";
    }

    public virtual string Tip()
    {
        return "Generica";
    }

    public virtual string InfoFis()
    {
        return $"Comp|{cod}";
    }

}
