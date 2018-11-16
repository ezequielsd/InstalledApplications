using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalledApplications
{
    public partial class Form1 : Form
    {

        CultureInfo culturaAtual;

        public Form1()
        {
            InitializeComponent();
            culturaAtual = CultureInfo.CurrentCulture;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AjustaIdioma(culturaAtual.Name);
            listViewProgramas.View = View.Details;
            listViewProgramas.Columns.Add("Programas", 500, HorizontalAlignment.Left);
            listViewProgramas.Columns.Add("Versão", 120, HorizontalAlignment.Left);
            AjustaIdiomaListView(culturaAtual.Name);
        }

        /// <summary>
        /// Change language to PT-br
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLanguagePTbr_Click(object sender, EventArgs e)
        {
            AjustaIdioma("pt-BR");
            AjustaIdiomaListView("pt-BR");
        }

        /// <summary>
        /// Change language to EN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLanguageEN_Click(object sender, EventArgs e)
        {
            AjustaIdioma("en-US");
            AjustaIdiomaListView("en-US");
        }

        /// <summary>
        /// Botão lista programas instalados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarProgramasLocal_Click(object sender, EventArgs e)
        {
            InsertItemsListView();
        }

        /// <summary>
        /// Insert list of applications
        /// </summary>
        private void InsertItemsListView()
        {
            var dados = RegistryFunctions.GetListApplicationsWin32();

            foreach (var dado in dados)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dado.Name;                                            
                item.SubItems.Add(dado.Version);

                listViewProgramas.Items.Add(item);
            }
        }
        
        /// <summary>
        /// Método ajusta o idioma da UI
        /// </summary>
        /// <param name="culturaName">Nome da cultura ativa na thread</param>
        private void AjustaIdioma(string culturaName)
        {
            Idioma.AjustaCultura(this, culturaName);

            switch (culturaName)
            {
                case "pt-BR":
                    btnLanguageEN.Enabled = true;
                    btnLanguagePTbr.Enabled = false;
                    break;
                case "en-US":
                    btnLanguageEN.Enabled = false;
                    btnLanguagePTbr.Enabled = true;
                    break;
                default:
                    break;
            }

            //ResourceManager rm = new ResourceManager("InstalledApplications.Resouces.Resource1",
            //Assembly.GetExecutingAssembly());
            //String strWebsite = rm.GetString("Website", CultureInfo.CurrentCulture);
            //String strName = rm.GetString("Name");
        }

        /// <summary>
        /// Método ajusta o idioma do listview
        /// </summary>
        /// <param name="culturaName">Nome da cultura ativa na thread</param>
        private void AjustaIdiomaListView(string culturaName)
        {
            switch (culturaName)
            {
                case "pt-BR":                  
                    listViewProgramas.Columns[0].Text = "Programas";                    
                    listViewProgramas.Columns[1].Text = "Versão";                  
                    break;
                case "en-US":
                    listViewProgramas.Columns[0].Text = "Program";
                    listViewProgramas.Columns[1].Text = "Version";                    
                    break;
                default:
                    break;
            }
        }
    }
}
