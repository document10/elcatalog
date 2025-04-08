using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TipDioda
{
    Redresoare,
    Zener,
    TVS,
    Schottky,
    Comutare
}

public class Dioda : Componenta
{
    public TipDioda tip { get; set; }
    public double tprag{ get; set; }
    public double tstr { get; set; }
    public double pmax { get; set; }
    public string mat { get; set; }
    public Dioda(string _cod="FARACODD", TipDioda _tip=TipDioda.Redresoare, double _tprag=0, double _tstr=0, double _pmax = 0, string _mat = "NESPEC") : base(_cod)
    {
        this.tip = _tip;
        this.tprag = _tprag;
        this.tstr = _tstr;
        this.pmax = _pmax;
        this.mat = _mat;
    }

    public Dioda(string linie)
    {
        string[] vals = linie.Split('|');
        this.cod = vals[1];
        this.tip = (TipDioda)Enum.Parse(typeof(TipDioda), vals[2]);
        this.tprag = double.Parse(vals[3]);
        this.tstr = double.Parse(vals[4]);
        this.pmax = double.Parse(vals[5]);
        this.mat = vals[6];
    }

    public override string ToString()
    {
        return $"Dioda {tip} ({cod}) din {mat}\ntensiune prag {tprag} V\ntensiune strapungere {tstr} V\nputere maxima {pmax} W";
    }

    public override string Tip()
    {
        return "Dioda";
    }

    public override string InfoFis()
    {
        return $"Dioda|{cod}|{tip.ToString()}|{tprag}|{tstr}|{pmax}|{mat}";
    }
}