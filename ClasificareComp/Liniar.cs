using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TipLiniar
{
    Rezistor,
    Condensator,
    Bobina
}

public class Liniar : Componenta
{
    TipLiniar tip;
    double val,vmax,pmax;
    Unitate unit;
    string mat;

    public Liniar(string _cod="FARACOD",TipLiniar _tip=TipLiniar.Rezistor, double _val = 0, Unitate _unit=Unitate.fara, double _vmax = 0, double _pmax = 0, string _mat = "NESPEC") : base(_cod)
    {
        this.tip = _tip;
        this.val = _val;
        this.unit = _unit;
        this.vmax = _vmax;
        this.pmax = _pmax;
        this.mat = _mat;
    }

    public override string Afisare()
    {
        string munit="";
        if (unit != Unitate.fara) munit = unit.ToString();
        switch (tip)
        {
            case TipLiniar.Rezistor:
                munit += "Ohmi";
                break;
            case TipLiniar.Condensator:
                munit += "Farazi";
                break;
            case TipLiniar.Bobina:
                munit += "Henry";
                break;
            default:
                munit += "err";
                break;
        }
        
        return $"{tip.ToString()} din {mat} ({cod}), {val} {munit}; Tensiune maxima {vmax} V; Putere Maxima {pmax} W";
    }
}
