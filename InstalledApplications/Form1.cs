using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalledApplications
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLanguagePTbr_Click(object sender, EventArgs e)
        {
            Idioma.AjustaCultura(this, "pt-BR");
        }

        private void btnLanguageEN_Click(object sender, EventArgs e)
        {
            Idioma.AjustaCultura(this, "en-US");
        }
    }
}
