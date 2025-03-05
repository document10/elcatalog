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
    public TipSursa tip;
    public Semnal semnal;
    public double val, freq, rezint;
    public Unitate uval,ufreq;

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

    public override string Afisare()
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
        if (semnal==Semnal.Continuu) return $"Sursa de {tip.ToString()} ({cod}) {val} {muval}, {rezint} Ohmi rezistenta interna";
        else
        {
            string mufreq = "";
            if (ufreq != Unitate.fara) mufreq = ufreq.ToString();
            mufreq += "Hertzi";
            return $"Sursa de {tip.ToString()} de ({cod}) de forma {semnal.ToString()}, {val} {muval} la {freq} {mufreq}, {rezint} Ohmi rezistenta interna";
        }
    }
}
