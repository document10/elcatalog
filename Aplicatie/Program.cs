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
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Instantiere interfata utilizator
            Application.SetCompatibleTextRenderingDefault(false);
            Principal principal = new Principal();
            Application.EnableVisualStyles();
            Application.Run(principal);
        }
    }
}
