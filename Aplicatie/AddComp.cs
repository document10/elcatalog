using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace Aplicatie
{
    public partial class AddComp: Form
    {
        private CatalogFisier cat;
        bool editMode = false;
        string prcod = "";
        int typeindex = 0;
        Componenta cedit;
        public AddComp(bool editMode=false,string cod="")
        {
            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            cat = new CatalogFisier(locatieFisierSolutie + "\\" + ConfigurationManager.AppSettings["NumeFisier"]);
            this.editMode = editMode;
            this.prcod = cod;
            cedit = cat.CautaCod(prcod)[0];
            switch (cedit.Tip())
            {
                case "Liniar":
                    clasificare.SelectedIndex = 0;
                    typeindex = 0;
                    break;
                case "Sursa":
                    clasificare.SelectedIndex = 1;
                    typeindex = 1;
                    break;
                case "Dioda":
                    clasificare.SelectedIndex = 2;
                    typeindex = 2;
                    break;
                case "Circuit Integrat":
                    clasificare.SelectedIndex = 3;
                    typeindex = 3;
                    break;
                default:
                    MessageBox.Show("Tip de componenta necunoscut!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
            this.DialogResult= DialogResult.Cancel;
        }

        private void AddComp_Load(object sender, EventArgs e)
        {
            //initializare eroare
            lblErr.Visible = false;
            //valori implicite meniuri
            if (!editMode)
            {
                clasificare.SelectedIndex = 0;
                cmbUnitLin.SelectedIndex = 4;
                cmbFrec.SelectedIndex = 4;
                cmbValSrs.SelectedIndex = 4;
                cmbSemn.SelectedIndex = 0;
                cmbTipDio.SelectedIndex = 0;
                lblErr.Visible = false;
            }
            else { 
                this.Text = "Editare componenta";
                txtCod.Text = cedit.cod;
                switch (cedit.Tip())
                {
                    case "Liniar":
                        this.Text = "Editare liniar";
                        Liniar lin = (Liniar)cedit;
                        txtValLin.Text = $"{lin.val}";
                        txtVmaxLin.Text = $"{lin.vmax}";
                        txtPmaxLin.Text = $"{lin.pmax}";
                        txtMatLin.Text = lin.mat;
                        cmbUnitLin.Text = $"{lin.unit}";
                        switch (lin.tip)
                        {
                            case TipLiniar.Rezistor:
                                rdbRez.Checked = true;
                                rdbCap.Checked = false;
                                rdbBob.Checked = false;
                                break;
                            case TipLiniar.Bobina:
                                rdbRez.Checked = false;
                                rdbCap.Checked = false;
                                rdbBob.Checked = true;
                                break;
                            case TipLiniar.Condensator:
                                rdbRez.Checked = false;
                                rdbCap.Checked = true;
                                rdbBob.Checked = false;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Sursa":
                        this.Text = "Editare sursa";
                        Sursa srs = (Sursa)cedit;
                        txtValSrs.Text = $"{srs.val}";
                        txtFrec.Text = $"{srs.freq}";
                        txtRez.Text = $"{srs.rezint}";
                        cmbFrec.Text = $"{srs.ufreq}";
                        cmbValSrs.Text = $"{srs.uval}";
                        cmbSemn.Text = $"{srs.semnal}";
                        switch (srs.tip)
                        {
                            case TipSursa.Tensiune:
                                rdbTen.Checked = true;
                                rdbAmp.Checked = false;
                                rdbPow.Checked = false;
                                break;
                            case TipSursa.Curent:
                                rdbTen.Checked = false;
                                rdbAmp.Checked = true;
                                rdbPow.Checked = false;
                                break;
                            case TipSursa.Putere:
                                rdbTen.Checked = false;
                                rdbAmp.Checked = false;
                                rdbPow.Checked = true;
                                break;
                            default:
                                break;
                        }
                        break;
                    case "Dioda":
                        this.Text = "Editare dioda";
                        Dioda dio = (Dioda)cedit;
                        txtMatDio.Text = dio.mat;
                        txtPmaxDio.Text = $"{dio.pmax}";
                        txtVpr.Text = $"{dio.tprag}";
                        txtVstr.Text = $"{dio.tstr}";
                        cmbTipDio.Text = $"{dio.tip}";
                        break;
                    case "Circuit Integrat":
                        this.Text = "Editare circuit integrat";
                        CircuitIntegrat cint = (CircuitIntegrat)cedit;
                        txtNume.Text = cint.nume;
                        txtPorts.Text = string.Join(" ",cint.porturi);
                        rtbSpecs.Text = string.Join("\n", cint.alteSpec);
                        break;
                    default:
                        MessageBox.Show("Tip de componenta necunoscut!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        break;
                }
            }
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            //Iinitializari
            lblErr.Visible = true;
            //verificare cod lipsa
            if (string.IsNullOrWhiteSpace(txtCod.Text))
            {
                lblErr.Text = "Codul componentei nu este completat!";
                return;
            }
            //verificare cod existent
            if (!cat.CodUnic(txtCod.Text)&&!editMode)
            {
                lblErr.Text = "Codul introdus exista deja!";
                return;
            }
            switch (clasificare.SelectedTab.Text)
            {
                case "Liniar":
                    //verificare campuri lipsa
                    if(string.IsNullOrWhiteSpace(txtValLin.Text))
                    {
                        lblErr.Text = "Valoarea nu este completata!";
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtVmaxLin.Text))
                    {
                        lblErr.Text = "Tensiunea maxima nu este completata!";
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtPmaxLin.Text))
                    {
                        lblErr.Text = "Puterea maxima nu este completata!";
                        return;
                    }
                    if(string.IsNullOrWhiteSpace(txtMatLin.Text))
                    {
                        lblErr.Text = "Materialul nu este completat!";
                        return;
                    }
                    //validare valori numerice
                    double valLin,pMaxLin, vMaxLin;
                    if (!double.TryParse(txtValLin.Text.Trim(), out valLin) || valLin < 0)
                    {
                        lblErr.Text = "Valoarea nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtVmaxLin.Text.Trim(), out vMaxLin) || vMaxLin < 0)
                    {
                        lblErr.Text = "Tensiunea maxima nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtPmaxLin.Text.Trim(), out pMaxLin) || pMaxLin < 0)
                    {
                        lblErr.Text = "Puterea nu este valida!";
                        return;
                    }
                    //configurare componenta
                    TipLiniar tipLin=TipLiniar.Rezistor;
                    if(rdbRez.Checked) tipLin = TipLiniar.Rezistor;
                    else if (rdbCap.Checked) tipLin = TipLiniar.Condensator;
                    else if (rdbBob.Checked) tipLin = TipLiniar.Bobina;
                    Unitate unitate = (Unitate)Enum.Parse(typeof(Unitate), cmbUnitLin.Text);
                    Liniar liniar = new Liniar(txtCod.Text.Trim(),tipLin,valLin,unitate,vMaxLin,pMaxLin,txtMatLin.Text.Trim());
                    if (!editMode)cat.Adauga(liniar);
                    else cat.Editare(prcod, liniar);
                    break;

                case "Sursa":
                    //verificare campuri lipsa
                    if (string.IsNullOrWhiteSpace(txtValSrs.Text))
                    {
                        lblErr.Text = "Valoarea nu este completata!";
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtFrec.Text))
                    {
                        lblErr.Text = "Frecventa nu este completata!";
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtRez.Text))
                    {
                        lblErr.Text = "Rezistenta nu este completata!";
                        return;
                    }
                    //validare valori numerice
                    double valSrs, frecSrs, rezInt;
                    if (!double.TryParse(txtValSrs.Text.Trim(), out valSrs)||valSrs < 0)
                    {
                        lblErr.Text = "Valoarea nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtFrec.Text.Trim(), out frecSrs)||frecSrs < 0)
                    {
                        lblErr.Text = "Frecventa nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtRez.Text.Trim(), out rezInt) || rezInt < 0)
                    {
                        lblErr.Text = "Rezistenta interna nu este valida!";
                        return;
                    }
                    //configurare componenta
                    TipSursa tipSrs = TipSursa.Tensiune;
                    if (rdbTen.Checked) tipSrs = TipSursa.Tensiune;
                    else if (rdbAmp.Checked) tipSrs = TipSursa.Curent;
                    else if (rdbPow.Checked) tipSrs = TipSursa.Putere;
                    Semnal tipSem = (Semnal)Enum.Parse(typeof(Semnal), cmbSemn.Text);
                    Unitate uval = (Unitate)Enum.Parse(typeof(Unitate), cmbValSrs.Text);
                    Unitate ufrec = (Unitate)Enum.Parse(typeof(Unitate),cmbFrec.Text);
                    Sursa sursa = new Sursa(txtCod.Text, tipSrs, tipSem, valSrs, frecSrs,uval,ufrec,rezInt);
                    if(!editMode)cat.Adauga(sursa);
                    else cat.Editare(prcod, sursa);
                    break;

                case "Dioda":
                    //verificare campuri goale
                    if(string.IsNullOrWhiteSpace(txtVpr.Text))
                    {
                        lblErr.Text = "Tensiunea prag nu este completata!";
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtVstr.Text))
                    {
                        lblErr.Text = "Tensiunea de strapungere nu este completata!";
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtPmaxDio.Text))
                    {
                        lblErr.Text = "Puterea maxima nu este completata!";
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtMatDio.Text))
                    {
                        lblErr.Text = "Materialul nu este completat!";
                        return;
                    }
                    //validare valori numerice
                    double vPr, vStr, pMaxDio;
                    if (!double.TryParse(txtVpr.Text.Trim(), out vPr) || vPr < 0)
                    {
                        lblErr.Text = "Tensiunea de prag nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtVstr.Text.Trim(), out vStr) || vStr < 0)
                    {
                        lblErr.Text = "Tensiunea de strapungere nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtPmaxDio.Text.Trim(), out pMaxDio) || pMaxDio < 0)
                    {
                        lblErr.Text = "Puterea maxima nu este valida!";
                        return;
                    }
                    //configurare componenta
                    TipDioda tipDioda = (TipDioda)Enum.Parse(typeof(TipDioda), cmbTipDio.Text);
                    Dioda dio = new Dioda(txtCod.Text, tipDioda, vPr, vStr, pMaxDio,txtMatDio.Text);
                    if(!editMode)cat.Adauga(dio);
                    else cat.Editare(prcod, dio);
                    break;

                case "Integrat":
                    //verificare campuri goale
                    if (string.IsNullOrWhiteSpace(txtNume.Text))
                    {
                        lblErr.Text = "Numele nu este completat!";
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(txtPorts.Text))
                    {
                        lblErr.Text = "Porturile nu sunt completate!";
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(rtbSpecs.Text))
                    {
                        lblErr.Text = "Specificatiile nu sunt completate!";
                        return;
                    }
                    //configurare componenta
                    List<string> porturi = txtPorts.Text.Split(' ').ToList();
                    List<string> specs = rtbSpecs.Text.Split('\n').ToList();
                    CircuitIntegrat ci = new CircuitIntegrat(txtCod.Text, txtNume.Text);
                    foreach (string port in porturi) if (!string.IsNullOrWhiteSpace(port.Trim())) ci.porturi.Add(port.Trim());
                    foreach (string spec in specs) if (!string.IsNullOrWhiteSpace(spec.Trim())) ci.alteSpec.Add(spec.Trim());
                    if (!editMode)cat.Adauga(ci);
                    else cat.Editare(prcod, ci);
                    break;

                default:
                    break;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void clasificare_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(editMode && clasificare.SelectedIndex != typeindex) clasificare.SelectedIndex = typeindex;
        }

        private void clasificare_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
