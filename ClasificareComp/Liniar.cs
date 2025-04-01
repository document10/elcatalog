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
    public TipLiniar tip { get; set; }
    public double val { get; set; }
    public double vmax { get; set; }
    public double pmax { get; set; }
    public Unitate unit { get; set; }
    public string mat { get; set; }

    public Liniar(string _cod="FARACOD",TipLiniar _tip=TipLiniar.Rezistor, double _val = 0, Unitate _unit=Unitate.fara, double _vmax = 0, double _pmax = 0, string _mat = "NESPEC") : base(_cod)
    {
        this.tip = _tip;
        this.val = _val;
        this.unit = _unit;
        this.vmax = _vmax;
        this.pmax = _pmax;
        this.mat = _mat;
    }

    public Liniar(string linie)
    {
        string[] vals = linie.Split('|');
        this.cod = vals[1];
        this.tip = (TipLiniar)Enum.Parse(typeof(TipLiniar), vals[2]);
        this.val = double.Parse(vals[3]);
        this.vmax = double.Parse(vals[4]);
        this.pmax = double.Parse(vals[5]);
        this.unit = (Unitate)Enum.Parse(typeof(Unitate), vals[6]);
        this.mat = vals[7];
    }

    public override string ToString()
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

    public override string InfoFis()
    {
        return $"Liniar|{cod}|{tip.ToString()}|{val}|{vmax}|{pmax}|{unit}|{mat}";
    }
}
