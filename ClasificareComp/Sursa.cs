using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum TipSursa
{
    Tensiune,
    Curent,
    Putere
}

public enum Semnal
{
    Continuu,
    Sinusoidal,
    Rectangular,
    Triunghiular,
    Fierastrau,
    Zgomot,
    Arbitrar
}

public class Sursa : Componenta
{
    public TipSursa tip { get; set; }
    public Semnal semnal { get; set; }
    public double val { get; set; }
    public double freq { get; set; }
    public double rezint { get; set; }
    public Unitate uval { get; set; }
    public Unitate ufreq { get; set; }

    public Sursa(string _cod="FARACOD", TipSursa _tip=TipSursa.Tensiune, Semnal _semnal=Semnal.Arbitrar, double _val=0, double _freq = 0, Unitate _uval=Unitate.fara, Unitate _ufreq=Unitate.fara, double _rezint=0):base(_cod)
    {
        this.tip = _tip;
        this.semnal = _semnal;
        this.val = _val;
        this.freq = _freq;
        this.uval = _uval;
        this.ufreq = _ufreq;
        this.rezint = _rezint;
    }

    public Sursa(string linie)
    {
        string[] vals = linie.Split('|');
        this.cod = vals[1];
        this.tip = (TipSursa)Enum.Parse(typeof(TipSursa), vals[2]);
        this.semnal = (Semnal)Enum.Parse(typeof(Semnal), vals[3]);
        this.val = double.Parse(vals[4]);
        this.freq = double.Parse(vals[5]);
        this.rezint = double.Parse(vals[6]);
        this.uval = (Unitate)Enum.Parse(typeof(Unitate), vals[7]);
        this.ufreq = (Unitate)Enum.Parse(typeof(Unitate), vals[8]);
    }

    public override string ToString()
    {
        string muval = "";
        if (uval != Unitate.fara) muval = uval.ToString();
        switch (tip)
        {
            case TipSursa.Tensiune:
                muval += "Volti";
                break;
            case TipSursa.Curent:
                muval += "Amperi";
                break;
            case TipSursa.Putere:
                muval += "Watti";
                break;
            default:
                muval += "err";
                break;
        }
        if (semnal==Semnal.Continuu) return $"Sursa Continua {tip.ToString()} de {val} {muval}\n{rezint} Ohmi rezistenta interna";
        else
        {
            string mufreq = "";
            if (ufreq != Unitate.fara) mufreq = ufreq.ToString();
            mufreq += "Hertzi";
            return $"Sursa de {tip.ToString()} de forma {semnal.ToString()}\n cu amplitudine de {val} {muval} la {freq} {mufreq}\n{rezint} Ohmi rezistenta interna";
        }
    }

    public override string Tip()
    {
        return "Sursa";
    }

    public override string InfoFis()
    {
        return $"Sursa|{cod}|{tip.ToString()}|{semnal.ToString()}|{val}|{freq}|{rezint}|{uval.ToString()}|{ufreq.ToString()}";
    }
}
