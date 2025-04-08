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

namespace Aplicatie
{
    public partial class AddComp: Form
    {
        private CatalogFisier cat;
        public AddComp()
        {
            InitializeComponent();
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            cat = new CatalogFisier(locatieFisierSolutie + "\\" + ConfigurationManager.AppSettings["NumeFisier"]);
        }

        private void AddComp_Load(object sender, EventArgs e)
        {
            //initializare eroare
            lblErr.Text = "";
            //valori implicite meniuri
            cmbTipLin.SelectedIndex = 0;
            cmbUnitLin.SelectedIndex = 4;
            cmbFrec.SelectedIndex = 4;
            cmbValSrs.SelectedIndex = 4;
            cmbSemn.SelectedIndex = 0;
            cmbTipSrs.SelectedIndex = 0;
            cmbTipDio.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Iinitializari
            string tab = "";
            
            if (string.IsNullOrWhiteSpace(txtCod.Text))
            {
                lblErr.Text = "Codul componentei nu este completat!";
                return;
            }
            switch (clasificare.SelectedTab.Text)
            {
                case "Liniar":
                    tab= "Liniar adaugat!";
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
                    if (!double.TryParse(txtValLin.Text.Trim(), out valLin))
                    {
                        lblErr.Text = "Valoarea nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtVmaxLin.Text.Trim(), out vMaxLin))
                    {
                        lblErr.Text = "Tensiunea maxima nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtPmaxLin.Text.Trim(), out pMaxLin))
                    {
                        lblErr.Text = "Puterea nu este valida!";
                        return;
                    }
                    //configurare componenta
                    TipLiniar tipLin = (TipLiniar)Enum.Parse(typeof(TipLiniar), cmbTipLin.Text);
                    Unitate unitate = (Unitate)Enum.Parse(typeof(Unitate), cmbUnitLin.Text);
                    Liniar liniar = new Liniar(txtCod.Text.Trim(),tipLin,valLin,unitate,vMaxLin,pMaxLin,txtMatLin.Text.Trim());
                    cat.Adauga(liniar);
                    break;

                case "Sursa":
                    tab = "Sursa adaugata!";
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
                    if (!double.TryParse(txtValSrs.Text.Trim(), out valSrs))
                    {
                        lblErr.Text = "Valoarea nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtFrec.Text.Trim(), out frecSrs))
                    {
                        lblErr.Text = "Frecventa nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtRez.Text.Trim(), out rezInt))
                    {
                        lblErr.Text = "Rezistenta interna nu este valida!";
                        return;
                    }
                    //configurare componenta
                    TipSursa tipSrs = (TipSursa)Enum.Parse(typeof(TipSursa), cmbTipSrs.Text);
                    Semnal tipSem = (Semnal)Enum.Parse(typeof(Semnal), cmbSemn.Text);
                    Unitate uval = (Unitate)Enum.Parse(typeof(Unitate), cmbValSrs.Text);
                    Unitate ufrec = (Unitate)Enum.Parse(typeof(Unitate),cmbFrec.Text);
                    Sursa sursa = new Sursa(txtCod.Text, tipSrs, tipSem, valSrs, frecSrs,uval,ufrec,rezInt);
                    cat.Adauga(sursa);
                    break;

                case "Dioda":
                    tab = "Dioda adaugata!";
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
                    if (!double.TryParse(txtVpr.Text.Trim(), out vPr))
                    {
                        lblErr.Text = "Tensiunea de prag nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtVstr.Text.Trim(), out vStr))
                    {
                        lblErr.Text = "Tensiunea de strapungere nu este valida!";
                        return;
                    }
                    if (!double.TryParse(txtPmaxDio.Text.Trim(), out pMaxDio))
                    {
                        lblErr.Text = "Puterea maxima nu este valida!";
                        return;
                    }
                    //configurare componenta
                    TipDioda tipDioda = (TipDioda)Enum.Parse(typeof(TipDioda), cmbTipDio.Text);
                    Dioda dio = new Dioda(txtCod.Text, tipDioda, vPr, vStr, pMaxDio,txtMatDio.Text);
                    cat.Adauga(dio);
                    break;

                case "Integrat":
                    tab = "Circuit Integrat adaugat!";
                    List<string> porturi = rtbPorts.Text.Split('\n').ToList();
                    List<string> specs = rtbSpecs.Text.Split('\n').ToList();
                    CircuitIntegrat ci = new CircuitIntegrat(txtCod.Text, txtNume.Text);
                    //verificare campuri goale
                    if (string.IsNullOrWhiteSpace(txtNume.Text))
                    {
                        lblErr.Text = "Numele nu este completat!";
                        return;
                    }
                    if (string.IsNullOrWhiteSpace(rtbPorts.Text))
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
                    foreach (string port in porturi)
                    {
                        if (!string.IsNullOrWhiteSpace(port.Trim()))
                            ci.porturi.Add(port.Trim());
                    }
                    foreach (string spec in specs)
                    {
                        if (!string.IsNullOrWhiteSpace(spec.Trim()))
                            ci.alteSpec.Add(spec.Trim());
                    }
                    cat.Adauga(ci);
                    break;

                default:
                    tab = "Componenta adaugata!";
                    break;
            }
            MessageBox.Show("Componenta a fost adaugata cu succes!", tab, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
