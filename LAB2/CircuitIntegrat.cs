using System;
using System.Collections.Generic;

public class CircuitIntegrat
{
    public string cod,nume;
    public List<string> porturi;
    public List<string> alteSpec;

    public CircuitIntegrat(string _cod = "FARACOD",string _nume="FARANUME")
    {
        cod = _cod;
        nume = _nume;
        porturi = new List<string>();
        alteSpec = new List<string>();
    }

    public string Afisare()
    {
        string ports = "",specs="";
        if (porturi.Count == 0) ports = "FARA";
        else foreach (string p in porturi) ports += $"{p}\n";
        if (alteSpec.Count == 0) specs = "NESPECIFICAT";
        else foreach (string s in alteSpec) specs+= $"{s}\n";
        return $"{nume}, cod {cod}, porturi:\n{ports}\nAlte specificatii:\n{specs}";
    }

}
