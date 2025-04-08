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
    public partial class Principal: Form
    {
        CatalogFisier catalog;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            catalog = new CatalogFisier(locatieFisierSolutie + "\\" + ConfigurationManager.AppSettings["NumeFisier"]);
            //afisare in tab1
            AfisareCatalog(catalog.CopieMemorie());
        }

        private void AfisareCatalog(Catalog memorie)
        {
            afisare.Rows.Clear();
            for (int i = 0; i < memorie.Nr; i++)
            {
                Componenta c = memorie.comps[i];
                afisare.Rows.Add(c.cod, c.Tip(), c.ToString());
                afisare.Rows[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddComp addComp = new AddComp();
            addComp.ShowDialog();
            addComp.Close();
            addComp.Dispose();
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
                   afisare.Rows.Add(txtCauta.Text,"Neidentificat",$"Nu am gasit componenta cu codul \"{txtCauta.Text}\"");
               }
               else
               {
                   afisare.Rows.Clear();
                   for (int i = 0; i < lista.Count; i++)
                   {
                       Componenta c = lista[i];
                       afisare.Rows.Add(c.cod, c.Tip(), c.ToString());
                       afisare.Rows[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                   }
               }
           }
        }

        private void afisare_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //va fi folosit pentru a edita componente mai incolo
            MessageBox.Show($"Se va edita componenta {afisare.Rows[e.RowIndex].Cells[1].Value}({afisare.Rows[e.RowIndex].Cells[0].Value})","Editare componenta",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
