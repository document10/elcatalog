using System;

public enum tip
{
    Generic,
    Rezistor,
    Condensator,
    Bobina,
    Tranzistor
}

public class Componenta
{
    string cod,unit;
    tip tipc;
    float val;

    public Componenta(string _c="FARACOD",string _unit="X",tip _t=tip.Generic,float _val=0.0f)
    {
        cod = _c;
        val = _val;
        tipc = _t;
        unit = _unit;
    }

    public string Afisare()
    {
        return $"{tipc.ToString()}, cod {cod}, {val} {unit}";
    }

}
