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
            //afisare in tab1
            AfisareCatalog(catalog.CopieMemorie());
            afisare.ClearSelection();
            afisare.CurrentCell = null;
        }

        private void AfisareCatalog(Catalog memorie)
        {
            afisare.Rows.Clear(); //curatare date vechi
            for (int i = 0; i < memorie.Nr; i++)
            {
                afisare.Rows.Add(memorie.comps[i].cod, memorie.comps[i].Tip(), memorie.comps[i].ToString());
                afisare.Rows[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //instantiere fereastra de adaugare
            AddComp addComp = new AddComp();
            addComp.ShowDialog();
            addComp.Close();
            addComp.Dispose();
            //reafisare catalog
            AfisareCatalog(catalog.CopieMemorie());
            afisare.ClearSelection();
            afisare.CurrentCell = null;
        }

        private void txtCauta_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCauta.Text))
            {
                afisare.Rows.Clear();
                AfisareCatalog(catalog.CopieMemorie());
            }
            else
            {
                List<Componenta> lista = catalog.CautaCod(txtCauta.Text);
                if (lista.Count == 0)
                {
                    afisare.Rows.Clear();
                    afisare.Rows.Add(txtCauta.Text, "Neidentificat", $"Nu am gasit componenta cu codul \"{txtCauta.Text}\"");
                }
                else
                {
                    afisare.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        afisare.Rows.Add(lista[i].cod, lista[i].Tip(), lista[i].ToString());
                        afisare.Rows[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    }
                }
            }
        }

        private void afisare_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return; //verificare daca s-a apasat pe header
            //va fi folosit pentru a edita componente mai incolo
            MessageBox.Show($"Se va edita componenta {afisare.Rows[e.RowIndex].Cells[1].Value}({afisare.Rows[e.RowIndex].Cells[0].Value})","Editare componenta",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            AfisareCatalog(catalog.CopieMemorie());
            afisare.ClearSelection();
            afisare.CurrentCell = null;
        }
    }
}
