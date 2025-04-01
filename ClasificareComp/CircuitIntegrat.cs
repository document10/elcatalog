using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CircuitIntegrat : Componenta
{
    public string nume { get; set; }
    public List<string> porturi { get; set; }
    public List<string> alteSpec { get; set; }

    public CircuitIntegrat(string _cod = "FARACOD",string _nume="FARANUME") :base(_cod)
    {
        nume = _nume;
        porturi = new List<string>();
        alteSpec = new List<string>();
    }

    public CircuitIntegrat(string linie)
    {
        string[] vals = linie.Split('|');
        this.cod = vals[1];
        this.nume = vals[2];
        this.porturi = new List<string>(vals[3].Split(';'));
        this.alteSpec = new List<string>(vals[4].Split(';'));
    }

    public override string ToString()
    {
        string ports = "",specs="";
        if (porturi.Count == 0) ports = "FARA";
        else ports = string.Join(" ", porturi);
        if (alteSpec.Count == 0) specs = "NESPECIFICAT";
        else specs = string.Join(" ",alteSpec);
        return $"{nume} ({cod}) porturi: {ports};Alte specificatii:{specs}";
    }

    public override string InfoFis()
    {
        return $"CI|{cod}|{nume}|{string.Join(";",porturi)}|{string.Join(";",alteSpec)}";
    }

}
