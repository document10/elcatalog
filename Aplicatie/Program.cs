using System;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aplicatie
{
    class InterfataUtilizator : Form
    {
        public Label[] compInfo;
        public GroupBox compGroup;
        public TextBox searchBox;
        public InterfataUtilizator(CatalogFisier catalog)
        {
            Catalog memorie = catalog.CopieMemorie();
            this.Width = 700;
            this.Height = 40 * catalog.Nr+20;
            this.Text = "Catalog Componente";
            this.BackColor = Color.FromArgb(255,255,255);
            this.compInfo = new Label[memorie.Nr];
            this.compGroup = new GroupBox();
            searchBox = new TextBox();
            searchBox.Location = new Point(0, 0);
            searchBox.Size = new Size(700, 10);
            searchBox.Font = new Font("Arial", 10, FontStyle.Regular);
            searchBox.Text = "";
            searchBox.ForeColor = Color.FromArgb(0, 0, 255);
            searchBox.KeyDown += (sender, e) =>
            {
                if(e.KeyCode != Keys.Enter) return;
                string cod = searchBox.Text;
                Componenta c = memorie.CautaCod(cod);
                if (c != null)MessageBox.Show(c.ToString(),"Rezultat Cautare",MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Componenta nu a fost gasita","Cautare esuata",MessageBoxButtons.OK, MessageBoxIcon.Error);  
            };
            this.Controls.Add(searchBox);
            compGroup.Location = new Point(0,20);
            compGroup.Size = new Size(700, 40*catalog.Nr);
            compGroup.BackColor = Color.FromArgb(255, 255, 255);
            for (int i = 0; i < catalog.Nr; i++)
            {
                Componenta c = memorie.comps[i];
                compInfo[i] = new Label();
                compInfo[i].Text = c.ToString();
                compInfo[i].Location = new Point(10, 20 + i * 30);
                compInfo[i].Size = new Size(700, 20);
                compInfo[i].ForeColor = Color.FromArgb(255*i/catalog.Nr, 255 * (catalog.Nr - i) / catalog.Nr, 255 * i / catalog.Nr);
                compInfo[i].Font = new Font("Arial", 10,FontStyle.Regular);
                compGroup.Controls.Add(compInfo[i]);
            }
            this.Controls.Add(compGroup);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string locatieFisierSolutie = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            CatalogFisier cat = new CatalogFisier(locatieFisierSolutie + "\\" + ConfigurationManager.AppSettings["NumeFisier"]);
            /*
            //Cod de test consola
            //Decomentati daca nu aveti fisierul initial
            cat.Adauga(new Componenta("1003"));
            cat.Adauga(new Liniar("1002", TipLiniar.Rezistor, 100, Unitate.fara, 500, 1200, "Ceramic"));
            cat.Adauga(new Sursa("1922", TipSursa.Putere, Semnal.Continuu, 100, 0, Unitate.fara, Unitate.fara, 0));
            cat.Adauga(new Sursa("1922", TipSursa.Tensiune, Semnal.Rectangular, 400, 3, Unitate.fara, Unitate.kilo, 0));
            cat.Adauga(new Dioda("1943", TipDioda.Zener, 0.7, 7, 100, "Germaniu"));
            CircuitIntegrat cint = new CircuitIntegrat("1432", "Punte redresoare");
            cint.porturi.Add("IN+");
            cint.porturi.Add("IN-");
            cint.porturi.Add("OUT+");
            cint.porturi.Add("OUT-");
            cint.alteSpec.Add("Tensiune Maxima: 400V");
            cat.Adauga(cint);
            
            //test eliminare componenta
            Console.WriteLine("Elimina o componenta dupa ID:");
            string ccod = Console.ReadLine();
            bool elim = cat.Elimina(ccod);
            if (elim == true) Console.WriteLine("Componenta Eliminata");
            else Console.WriteLine("Nu a fost gasit");
            //copia in memorie va fi necesara pentru afisare
            Catalog mcat = cat.CopieMemorie();
            Console.WriteLine($"Nr total componente: {cat.Nr}\n{mcat.Inventar()}\nReprezentare Fisier:\n{mcat.InvFis()}\nCauta dupa cod:");
            //test cautare componenta
            ccod = Console.ReadLine();
            Componenta cc = cat.CautaCod(ccod);
            if (cc != null) Console.WriteLine(cc.ToString());
            else Console.WriteLine("Nu a fost gasit");
            */
            //Instantiere interfata utilizator
            InterfataUtilizator interfata = new InterfataUtilizator(cat);
            Application.Run(interfata);
        }
    }
}
