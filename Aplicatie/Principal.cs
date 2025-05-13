using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace Aplicatie
{
    public partial class Principal : MetroForm
    {
        CatalogFisier catalog;
        Catalog memorie;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //initializare forma
            this.AutoSize = true;
            //creare catalog
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            catalog = new CatalogFisier(locatieFisierSolutie + "\\" + ConfigurationManager.AppSettings["NumeFisier"]);
            memorie = catalog.CopieMemorie();
            //afisare in tab1
            AfisareCatalog(memorie.comps);
            afisare.ClearSelection();
            afisare.CurrentCell = null;
            //initializare eroare
            lblErr.Text = "";
        }

        private void AfisareCatalog(List<Componenta> comps)
        {
            afisare.Rows.Clear(); //curatare date vechi
            for (int i = 0; i < comps.Count; i++)
            {
                afisare.Rows.Add(comps[i].cod, comps[i].Tip(), comps[i].ToString());
                afisare.Rows[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //instantiere fereastra de adaugare
            AddComp addComp = new AddComp();
            addComp.ShowDialog();
            addComp.Close();
            //reafisare catalog
            if (addComp.DialogResult == DialogResult.OK)
            {
                memorie = catalog.CopieMemorie(); //actualizare memorie
                AfisareCatalog(memorie.comps);
                afisare.ClearSelection();
                afisare.CurrentCell = null;
            }
        }

        private void afisare_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return; //verificare daca s-a apasat pe header
            //va fi folosit pentru a edita componente mai incolo
            //MessageBox.Show($"Se va edita componenta {afisare.Rows[e.RowIndex].Cells[1].Value}({afisare.Rows[e.RowIndex].Cells[0].Value})","Editare componenta",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Componenta componenta = catalog.CautaCod(afisare.Rows[e.RowIndex].Cells[0].Value.ToString())[0];
            AddComp addComp = new AddComp(true, afisare.Rows[e.RowIndex].Cells[0].Value.ToString());
            addComp.ShowDialog();
            addComp.Close();
            //reafisare catalog
            if (addComp.DialogResult == DialogResult.OK)
            {
                memorie = catalog.CopieMemorie(); //actualizare memorie
                AfisareCatalog(memorie.comps);
                afisare.ClearSelection();
                afisare.CurrentCell = null;
            }
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            if (afisare.CurrentRow.Index < 0) return; //verificare daca s-a apasat pe header
            Componenta comp = catalog.CautaCod(afisare.CurrentRow.Cells[0].Value.ToString())[0];
            //mesaj confirmare stergere
            DialogResult dialog = MessageBox.Show($"Sigur doriti sa stergeti componenta {comp.Tip()}({comp.cod})?", "Stergere componenta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No) return;
            //stergere componenta
            catalog.Elimina(afisare.CurrentRow.Cells[0].Value.ToString());
            MessageBox.Show($"Componenta {comp.Tip()}({comp.cod}) a fost stearsa cu succes!", "Stergere componenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //reafisare catalog
            memorie = catalog.CopieMemorie(); //actualizare memorie
            AfisareCatalog(memorie.comps);
            afisare.ClearSelection();
            afisare.CurrentCell = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCrit.Text = "";
            lblErr.Text = "";
            AfisareCatalog(memorie.comps);
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            List<Componenta> rez= new List<Componenta>();
            int val;
            if (string.IsNullOrWhiteSpace(txtCrit.Text))
            {
                lblErr.Text = "Introduceti un criteriu de cautare!";
                return;
            }
            lblErr.Text = "";
            if (rdbCod.Checked)
            {
                rez = catalog.CautaCod(txtCrit.Text);
            }
            else if (rdbVal.Checked)
            {
                if (!int.TryParse(txtCrit.Text, out val)||val<0)
                {
                    lblErr.Text = "Introduceti o valoare valida!";
                    return;
                }
                foreach (Componenta c in memorie.comps)
                {
                    if (c.Tip() == "Liniar")
                    {
                        Liniar liniar = (Liniar)c;
                        if (liniar.val == val)rez.Add(liniar);
                    }
                    if (c.Tip() == "Sursa")
                    {
                        Sursa sursa = (Sursa)c;
                        if (sursa.val == val)rez.Add(sursa);
                    }
                }
            }
            else if (rdbVmax.Checked) {
                if (!int.TryParse(txtCrit.Text, out val)||val < 0)
                {
                    lblErr.Text = "Introduceti o valoare valida!";
                    return;
                }
                foreach (Componenta c in memorie.comps)
                {
                    if (c.Tip() == "Liniar")
                    {
                        Liniar liniar = (Liniar)c;
                        if (liniar.vmax == val)rez.Add(liniar);
                    }
                }
            }
            else if (rdbPmax.Checked)
            {
                if (!int.TryParse(txtCrit.Text, out val) || val < 0)
                {
                    lblErr.Text = "Introduceti o valoare valida!";
                    return;
                }
                foreach (Componenta c in memorie.comps)
                {
                    if (c.Tip() == "Liniar")
                    {
                        Liniar liniar = (Liniar)c;
                        if (liniar.pmax == val) rez.Add(liniar);
                    }
                    if(c.Tip() == "Dioda")
                    {
                        Dioda dioda = (Dioda)c;
                        if (dioda.pmax == val) rez.Add(dioda);
                    }
                }
            }
            if (rez.Count > 0) AfisareCatalog(rez);
            else
            {
                lblErr.Text = "Componenta nu a fost gasita!";
                return;
            }
            lblErr.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
