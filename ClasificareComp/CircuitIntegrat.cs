using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CircuitIntegrat : Componenta
{
    public string nume;
    public List<string> porturi;
    public List<string> alteSpec;

    public CircuitIntegrat(string _cod = "FARACOD",string _nume="FARANUME") :base(_cod)
    {
        nume = _nume;
        porturi = new List<string>();
        alteSpec = new List<string>();
    }

    public override string Afisare()
    {
        string ports = "",specs="";
        if (porturi.Count == 0) ports = "FARA";
        else foreach (string p in porturi) ports += $"{p} ";
        if (alteSpec.Count == 0) specs = "NESPECIFICAT";
        else foreach (string s in alteSpec) specs+= $"{s} ";
        return $"{nume} ({cod}) porturi: {ports};Alte specificatii:{specs}";
    }

}
